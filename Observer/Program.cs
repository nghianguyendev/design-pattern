using System;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Observer design pattern!");

            var stockIBM = new IBM("IBM", 100);
            var investors = new List<IInvestor>() { new Investor("Investor A"), new Investor("Investor B") };

            stockIBM.AddInvestor(investors);
            stockIBM.Price += 100;
        }
    }
}
