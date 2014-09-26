using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage Sklad = new Storage();
            Goods tovar = new Goods("Батон", 100, 10, 10.5, "горчичный");

            Sklad.input(tovar);

        }
    }
}