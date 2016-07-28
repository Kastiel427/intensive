using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Collections.Generic;
using System.Web.Http;

[assembly: OwinStartup(typeof(Task5.Startup))]

namespace Task5
{
    using AppFunc = Func<IDictionary<string, object>, Task>; 

    public class Startup
    {
        public IEnumerable<int> GetNumber(int count)
        {
            Random rand = new Random();

            for (int i = 0; i < count; i++)
            {
                yield return rand.Next(0, 100); 
            }
        }

        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("default", "{controller}");
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            app.UseWebApi(config);

            //app.Use(new Func<AppFunc, AppFunc>(next =>
            //    env =>
            //    {
            //        var response = new OwinResponse(env);
            //        response.WriteAsync("Hello, my name is Artem \n");
            //        return next(env);
            //    }));

            //app.Use(new Func<AppFunc, AppFunc>(next =>
            //    env =>
            //    {
            //        var response = new OwinResponse(env);
            //        var list = GetNumber(10);

            //        foreach (int n in list)
            //        {
            //            response.WriteAsync("\n" + n);
            //        }

            //        return next(env);
            //    }));


            app.Run(context =>
            {
                return context.Response.WriteAsync("\nHello world");
            });
        }
    }
}
