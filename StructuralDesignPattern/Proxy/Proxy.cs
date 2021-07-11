using System;
using System.Collections.Generic;

namespace Proxy
{
    internal interface IInternetAccess
    {
        void ConnectTo(string address);
    }

    internal class RealInternetAccess : IInternetAccess
    {
        public void ConnectTo(string address)
        {
            Console.WriteLine("Connecting to " + address);
        }
    }

    internal class ProxyInternetAccess : IInternetAccess
    {
        private List<string> bannedSites = new List<string> {
            "google.com",
            "microsoft.com"
        };

        private RealInternetAccess internetAccess = new RealInternetAccess();

        public void ConnectTo(string address)
        {
            if (bannedSites.Contains(address))
            {
                Console.WriteLine($"{address} Access denied");
                return;
            }

            internetAccess.ConnectTo(address);
        }
    }
}