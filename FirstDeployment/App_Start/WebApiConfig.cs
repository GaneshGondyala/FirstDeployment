using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FirstDeployment
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Clear all existing formatters and use JSON formatter
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());

            // Remove XML formatter if not needed
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Enable attribute routing (for routing based on attributes like [Route])
            config.MapHttpAttributeRoutes();

            // Enable CORS (Cross-Origin Resource Sharing)
            var corsAttr = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(corsAttr);
        }
    }
}
