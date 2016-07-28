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
            var confic = new HttpConfiguration();
            confic.MapHttpAttributeRoutes();
            confic.Routes.MapHttpRoute("default", "{controller}");
            confic.Formatters.Remove(confic.Formatters.XmlFormatter);
            app.UseWebApi(confic);
        }
    }
}
