using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tovar
{
    class Program
    {
        static void Main(string[] args)
        {
            Tovar T = new Tovar("Банан","Украина",10);
            Console.WriteLine(T);

            Food P = new Food("Кокос", "Украина", 20.75);
            Console.WriteLine(P);

            //Console.WriteLine(Object.Equals(T,T));

           // Object.re
            Object obj = P;
            Console.WriteLine(obj.GetType());

        }
    }
}
