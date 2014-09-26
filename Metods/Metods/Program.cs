using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            
            Console.WriteLine(p.Cube());
        }

        double Cube(double N=3)
        {
            return N * N * N;
        }

    }
}
