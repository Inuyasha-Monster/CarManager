using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using WebApiContrib.Formatting.Jsonp;

namespace CarManager.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.JsonFormatter.MediaTypeMappings.Add(new QueryStringMapping(queryStringParameterName: "formate", queryStringParameterValue: "json", mediaType: "application/json"));

            config.Formatters.XmlFormatter.MediaTypeMappings.Add(new QueryStringMapping(queryStringParameterName: "formate", queryStringParameterValue: "xml", mediaType: "application/xml"));

            config.Filters.Add(new CustomFilters.CustomExceptionFilterAttribute());

            config.MessageHandlers.Add(new CustomFilters.MyMessageHandler());

            // Web API 配置和服务
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();

            config.AddJsonpFormatter();
            config.EnableCors();

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
