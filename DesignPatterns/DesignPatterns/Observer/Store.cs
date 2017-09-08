using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    abstract class Store
    {
        private List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Deattach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void notify()
        {
            foreach (Observer observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
