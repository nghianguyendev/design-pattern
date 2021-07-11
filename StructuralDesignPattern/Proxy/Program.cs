using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Proxy design pattern!");

            var proxyInternetAccess = new ProxyInternetAccess();

            proxyInternetAccess.ConnectTo("mysite.net");
            
            //will throw exception
            proxyInternetAccess.ConnectTo("google.com");
        }
    }
}
