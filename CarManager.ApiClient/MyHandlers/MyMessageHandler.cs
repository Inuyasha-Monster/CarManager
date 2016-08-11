using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarManager.ApiClient.MyHandlers
{
    public class MyMessageHandler : System.Net.Http.DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("x-app-key", "djlnet");
            return base.SendAsync(request, cancellationToken);
        }
    }
}
