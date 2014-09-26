using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomFigure
{
    class Program
    {
        delegate double MyDelegat();
        
        static void Main(string[] args)
        {

            Paralelogramm P = new Paralelogramm(10, 15, 30);
            Console.WriteLine("{0}\nПлощадь:\t{1}\nПериметр:\t{2}",P,P.Area,P.Perimeter);

            Console.WriteLine("Паралелограм: 1 - площадь, 2 - периметр");
            
            bool done = false;


            MyDelegat Method = new MyDelegat(P.mArea);
            do
            {
                int i = Int32.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1: done = true; break;
                    case 2: Method = P.mPerimeter; done = true; break;
                }
            }
            while (!done);

            Console.WriteLine(Method());
            
        }
    }
}
