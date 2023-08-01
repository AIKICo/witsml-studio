// See https://aka.ms/new-console-template for more information
using System.ServiceModel;
using WitsmlStoreServiceReference;

Console.WriteLine("Starting...");
BasicHttpsBinding binding = new BasicHttpsBinding();
binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
EndpointAddress endpoint = new("https://witsserver.oxinpetro.com/WitsmlStore.svc");

WitsmlStoreClient client = new(binding, endpoint);
string out1, out2;

client.ClientCredentials.UserName.UserName = "administrator";
client.ClientCredentials.UserName.Password = "Kabinet95##@";

client.WMLS_GetCap(string.Empty, out out1, out out2);

client.Close();