using AIKI.CO.OilWell.Monitoring.Models;
using AIKI.CO.OilWell.Monitoring.Settings;
using RabbitMQ.Client;
using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WitsmlAgentCore;

namespace AIKI.CO.OilWell.Monitoring.RabbitmqHelper
{
    public class WitsmlDataMessageReceiver : AsyncDefaultBasicConsumer
    {
        private readonly IModel _channel;

        public event EventHandler<WitsmlEventArgs>? HandleMessage;
        public WitsmlDataMessageReceiver(IModel channel) => _channel = channel;

        public override Task HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, IBasicProperties properties, ReadOnlyMemory<byte> body)
        {
            var dict = Encoding.UTF8.GetString(body.ToArray());
            var decryptedDict = AesOperation.DecryptString(Utils.ConvertSecureStringToString(ConstantsProperties.EncryptionKey), dict);
            var record = JsonSerializer.Deserialize<WellRecord>(decryptedDict);
            if (record != null) 
            {
                HandleMessage?.Invoke(null, new WitsmlEventArgs { WellRecord = record, WellInfoKey = routingKey });
            }           
            return base.HandleBasicDeliver(consumerTag, deliveryTag, redelivered, exchange, routingKey, properties, body);
        }
    }
}
