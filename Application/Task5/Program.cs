using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Microsoft.Owin.Hosting.WebApp.Start<Startup>("http://localhost:8082"))
            {
                Console.WriteLine("Сервер запущен");
                Console.ReadKey();
            };
        }
    }
}
