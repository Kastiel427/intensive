using Owin;
using Microsoft.Owin;
using System.Web.Http;



namespace Taks1
{
    [assebmly: OwinStartup(typeof(Task1.Startup))]

    class Startup
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
