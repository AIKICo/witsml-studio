// See https://aka.ms/new-console-template for more information
using System.ServiceModel;
using WitsmlStoreServiceReference;

Console.WriteLine("Hello, World!");
BasicHttpsBinding binding = new BasicHttpsBinding();
binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
EndpointAddress endpoint = new EndpointAddress("https://witsserver.oxinpetro.com/WitsmlStore.svc");

WitsmlStoreClient client = new WitsmlStoreClient(binding, endpoint);
string out1, out2;

client.ClientCredentials.UserName.UserName = "administrator";
client.ClientCredentials.UserName.Password = "Kabinet95##@";

client.WMLS_GetCap(string.Empty, out out1, out out2);
client.Close();