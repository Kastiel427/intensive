using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin;
using Microsoft.Owin;
using Microsoft.Owin.Hosting;


namespace Taks1
{
    class Program
    {
        public static List<Tasks> tasks = new List<Tasks>();

        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>(new StartOptions { Port = 5555 }))
            {
                Console.WriteLine("Сервер запущен");
                Console.ReadKey();
            }
        }
    }
}
