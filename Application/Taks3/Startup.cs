using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(Task3_2.Startup))]

namespace Task3_2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            
            config.MapHttpAttributeRoutes();

            config.Filtres.Add(new HeaderIDMVC());
            config.Filtres.Add(new HeaderID());

            config.Routes.MapHttpRoute("default", "{controller}");

            config.Formatters.Remove(config.Formatters.XmlFormatter);


            app.UseWebApi(config);
        }
    }
}
