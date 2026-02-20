using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // 2. The Subject (Observable)
    public class Stock
    {
        private List<IInvestor> _observers = new List<IInvestor>();
        private double _price;
        public string Symbol { get; }

        public Stock(string symbol, double price)
        {
            Symbol = symbol;
            _price = price;
        }

        public void Attach(IInvestor investor) => _observers.Add(investor);
        public void Detach(IInvestor investor) => _observers.Remove(investor);

        public double Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify(); // Automatically notify on change
                }
            }
        }

        private void Notify()
        {
            foreach (var observer in _observers)
                observer.Update(Symbol, _price);
        }
    }
}
