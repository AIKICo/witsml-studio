﻿using AIKI.CO.OilWell.Monitoring.Models;
using AIKI.CO.OilWell.Monitoring.RabbitmqHelper;
using AIKI.CO.OilWell.Monitoring.RavenDB;
using AIKI.CO.OilWell.Monitoring.Settings;
using AIKI.CO.OilWell.Monitoring.WitsML;
using Energistics.DataAccess;
using RabbitMQ.Client;
using System.ServiceModel;
using System.Text;
using WitsmlAgentCore;
using WitsmlStoreServiceReference;

List<RecordsInfo>? wellsInfo = null;

Console.WriteLine("Starting...");
BasicHttpsBinding binding = new();
binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

EndpointAddress endpoint = new(new Uri("https://witsserver.oxinpetro.com/WitsmlStore.svc"));

Console.WriteLine("Loading Wells Info...");

wellsInfo = await LogCreator.LoadAllTransferChannels();

Console.WriteLine("SOAP Client Creating...");

WitsmlStoreClient client = new(binding, endpoint);

client.ClientCredentials.UserName.UserName = "administrator";
client.ClientCredentials.UserName.Password = "Kabinet95##@";
client.Endpoint.EndpointBehaviors.Add(new CorrelationEndpointBehavior());


Console.WriteLine("Start Listening...");
using (IConnection messageBrokerConnection = ConstantsProperties.GetMessageBrokerConnection())
{
    using IModel channel = messageBrokerConnection.CreateModel();
    var messageReceiver = new WitsmlDataMessageReceiver(channel);
    MudLogCreator witsmlLog = new();
    Dictionary<string, List<WellRecord>> logRecords = new();

    messageReceiver.HandleMessage += async (s, e) =>
    {
        if(e.WellInfoKey==null) return;

        if (!logRecords.ContainsKey(e.WellInfoKey))
        {
            logRecords.Add(e.WellInfoKey, new List<WellRecord>());
            logRecords[e.WellInfoKey].Add(e.WellRecord!.Clone());
        }
        else
        {
            logRecords[e.WellInfoKey].Add(e.WellRecord!.Clone());
        }

        foreach(var item in logRecords)
        {
            if (item.Value.Count == 5)
            {
                try
                {
                    ConstantsProperties.SelectedWellInfo = wellsInfo.SingleOrDefault(x => x.Id == item.Key);
                    if (ConstantsProperties.SelectedWellInfo == null) return;
                    var logs = witsmlLog.GenerateMudLog_1_4_1_1(item.Value.ToList(), 5, withoutSave: true);
                    var xmlIn = EnergisticsConverter.ObjectToXml(logs, Encoding.UTF8);
                    var response = await client.WMLS_AddToStoreAsync(new WMLS_AddToStoreRequest
                    {
                        WMLtypeIn = "mudLog",
                        CapabilitiesIn = null,
                        OptionsIn = null,
                        XMLin = xmlIn
                    });

                    if (response.Result == 1)
                    {
                        Console.WriteLine($"Writing Witsmllog at {item.Value.First().Rdtime} for {item.Key}");
                        item.Value.Clear();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    };
    var consumeTag = channel.BasicConsume(
        queue: "OPC_ALL_WITSSERVER_QUEUE",
        autoAck: true,
        consumer: messageReceiver,
        exclusive: true);
    Console.ReadKey();
}


client.Close();