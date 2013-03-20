using System;
using Microsoft.Owin.Hosting;
using Owin;

namespace MathServer
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverUrl = "http://localhost:8080";

            // Start Server & Host Math Service
            var server = WebApplication.Start<ServerStartup>(serverUrl);
            Console.WriteLine("Server running on {0}", serverUrl);

            Console.ReadKey();
        }

    }

    class ServerStartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapHubs();
        }
    }
}
