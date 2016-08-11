using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json.Serialization;

namespace CarManager.WebCore.MVC
{
    public class JsonNetResult : JsonResult
    {
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            var response = context.HttpContext.Response;
            if (string.IsNullOrWhiteSpace(response.ContentType))
            {
                response.ContentType = "application/json";
            }
            if (response.ContentEncoding != null)
            {
                response.ContentEncoding = Encoding.UTF8;
            }
            Newtonsoft.Json.JsonSerializerSettings settings = new Newtonsoft.Json.JsonSerializerSettings()
            {
                DateFormatString = "yyyy-MM-dd HH:mm:ss",
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            var result = Newtonsoft.Json.JsonConvert.SerializeObject(this.Data, Newtonsoft.Json.Formatting.None, settings);
            response.Write(result);
        }
    }
}
