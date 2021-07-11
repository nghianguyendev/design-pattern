using System;
using System.Collections.Generic;

namespace Observer
{
    internal abstract class Stock
    {
        private List<IInvestor> _investors = new List<IInvestor>();

        public string Name { get; set; }

        private double _price;

        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
                foreach (var investor in _investors)
                {
                    investor.Update(this);
                }
            }
        }

        protected Stock(string name, double price)
        {
            Name = name;
            _price = price;
        }

        public void AddInvestor(List<IInvestor> investors)
        {
            _investors.AddRange(investors);
        }
    }

    internal class IBM : Stock
    {
        public IBM(string name, double price) : base(name, price)
        {
        }
    }

    internal interface IInvestor
    {
        void Update(Stock stock);
    }

    internal class Investor : IInvestor
    {
        public string Name { get; set; }

        public Investor(string name)
        {
            Name = name;
        }
        public void Update(Stock stock)
        {
            Console.WriteLine($"Notified to {Name} that Stock {stock.Name} changed to {stock.Price}");
        }
    }
}