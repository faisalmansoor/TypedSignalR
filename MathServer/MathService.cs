using System;
using System.Collections.Generic;
using MathContract;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using TypedSignalR;

namespace MathServer
{
    [HubName("Math")]
    public class MathService : Hub, IMathService
    {
        #region Implementation of IMathService

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public List<int> ListPrimes(int num)
        {
            var callback = this.CallerAs<IClientCallback>();
            callback.Notify("Adding");

            var primes = new List<int>();
            for (int i = 1; i < num; i++)
            {
                bool isPrime = true;
                for (int d = 2; d < i; d++)
                {
                    if (i % d == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primes.Add(i);
                }

                if(i % 10 == 0)
                {
                    callback.Notify(string.Format("ListPrimes {0}% Complete.", (i*100) / num ));
                }
            }
            return primes;
        }

        public void NotifyClient(string id)
        {
            var callback = this.CallerAs<IClientCallback>();
            callback.Notify("Notifying: " + id );
        }

        #endregion
    }
}