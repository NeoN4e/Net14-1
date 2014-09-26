using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string item in args)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }

    partial class Auto
    {
        bool handBreak;
        int speed;
    }
}

