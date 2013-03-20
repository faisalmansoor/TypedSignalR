using System;
using System.Collections.Generic;
using MathContract;
using Newtonsoft.Json;
using TypedSignalR;

namespace MathClient
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = JsonConvert.SerializeObject("abcd");
            JsonConvert.DeserializeObject("\"A string\"", typeof(string));

            string serverUrl = "http://localhost:8080";

            // Get MathService Proxy
            var connection = new TypedHubConnection(serverUrl);

            IMathService mathProxy = connection.CreateProxy<IMathService>("Math");

            // Configure Callback class
            IDualProxy dualProxy = (IDualProxy)mathProxy;
            dualProxy.Subscribe(new ClientCallback());
            
            int sum = mathProxy.Add(10, 20);
            Console.WriteLine("10 + 20 = " + sum );

            Console.WriteLine();

            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Asking notification: " + i);
                mathProxy.NotifyClient(i.ToString());
            }

            List<int> primes100 = mathProxy.ListPrimes(100);
            Console.WriteLine("Primes < 100: " + String.Join(",", primes100));

        }

        static void RunTest()
        {
            string serverUrl = "http://localhost:8080";

            // Get MathService Proxy
            var connection = new TypedHubConnection(serverUrl);

            IMathService mathProxy = connection.CreateProxy<IMathService>("Math");

            // Configure Callback class
            IDualProxy dualProxy = (IDualProxy)mathProxy;
            dualProxy.Subscribe(new ClientCallback());

            int sum = mathProxy.Add(10, 20);
            Console.WriteLine("10 + 20 = " + sum);

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Asking notification: " + i);
                mathProxy.NotifyClient(i.ToString());
            }

            List<int> primes100 = mathProxy.ListPrimes(100);
            Console.WriteLine("Primes < 100: " + String.Join(",", primes100));

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

}
