using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace CarManager.Api.CustomFilters
{
    public class MyMessageHandler : System.Net.Http.DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            System.Diagnostics.Debug.WriteLine("start");
            var response = base.SendAsync(request, cancellationToken);
            System.Diagnostics.Debug.WriteLine("end");
            return response;
        }
    }
}