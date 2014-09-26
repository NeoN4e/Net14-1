using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gs
{
    class Program
    {
        static void Main(string[] args)
        {
            test t = new test();

            List<test> l1 = new List<test>();
            List<test> l2 = new List<test>();

            l1.Add(t);
            l2.Add(t);

            Console.WriteLine(l1.Count);
            Console.WriteLine(l2.Count);

            GC.SuppressFinalize(t);
            Console.WriteLine(GC.GetGeneration(t));

            Console.WriteLine(l1.Count);
            Console.WriteLine(l2.Count);
        }

    }

    class test : IDisposable
    {
        public test()
        { }

        ~test()
        {
            Console.WriteLine("test");
        }

        void IDisposable.Dispose()
        {
            Console.WriteLine("Dispose");
        }
    }
}
