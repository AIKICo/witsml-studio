using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitsmlAgentCore
{
    public class CustomCorrelationDelegatingHandler : DelegatingHandler
    {
        public CustomCorrelationDelegatingHandler(HttpClientHandler handler)
        {
            InnerHandler = handler;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("user-agent", "OPC Mud Logger");
            return base.SendAsync(request, cancellationToken);
        }
    }
}
