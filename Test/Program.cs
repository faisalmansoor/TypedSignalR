using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;
using Owin;
using TypedSignalR;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var exit = new ManualResetEvent(false);
            var serverUp = new ManualResetEvent(false);
            string serverUrl = "http://localhost:8080";

            Task serverTask = Task.Factory.StartNew(() =>
                     {
                         // Start Server & Host Math Service
                         var server = WebApplication.Start<ServerStartup>(serverUrl);
                         Console.WriteLine("Server running on {0}", serverUrl);

                         serverUp.Set();

                         exit.WaitOne();

                         return;
                     }
                );

            serverUp.WaitOne();

            // Get MathService Proxy
            var connection = new TypedHubConnection(serverUrl);

            IMathService mathProxy = connection.CreateProxy<IMathService>("Math");

            // Configure Callback class
            IDualProxy dualProxy = (IDualProxy)mathProxy;
            ClientCallback callback = new ClientCallback();
            dualProxy.Subscribe(callback);
            
            int sum = mathProxy.Add(10, 20);
            Console.WriteLine("10 + 20 = " + sum );

            Console.WriteLine();

            List<int> primes100 = mathProxy.ListPrimes(100);
            Console.WriteLine("Primes < 100 " + String.Join(",", primes100));

        }

        public class ClientCallback : IClientCallback
        {
            #region Implementation of IClientCallback

            public void Notify(string msg)
            {
                Console.WriteLine("Client: {0}", msg);
            }

            #endregion
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
