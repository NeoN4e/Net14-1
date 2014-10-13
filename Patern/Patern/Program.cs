using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    delegate void MyDelegate();

    interface IObserver
    {
        void Notify();
    }

    abstract class Human : IObservable<Human>
    {
        List<IObserver> observers = new List<IObserver>();

        public void add(IObserver o)
        {
            observers.Add(o);
        }

        public void Delete(IObserver o)
        {
            observers.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserver i in observers)
            {
                i.Notify();
            }
        }
    }
}