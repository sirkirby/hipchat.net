using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HipChatWeb
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {
      // Web API configuration and services
      // Configure Web API to use only bearer token authentication.
      config.SuppressDefaultHostAuthentication();
      //config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

      // Use camel case for JSON data.
      config.Formatters.Remove(config.Formatters.XmlFormatter);
      config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
      config.Formatters.JsonFormatter.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;

      // Web API routes
      config.MapHttpAttributeRoutes();

      config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/{controller}/{id}",
          defaults: new { id = RouteParameter.Optional }
      );
    }
  }
}
