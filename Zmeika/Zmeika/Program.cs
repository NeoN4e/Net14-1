using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika
{
    class Program
    {
        static void Main(string[] args)
        {
            Zmeya zmeya = new Zmeya();
           // Console.WriteLine(zmeya.exist(1,1));
                
            Map map = new Map(zmeya,10);

            try
            {
                do
                {
                    System.Threading.Thread.Sleep(500);

                    Console.Clear();
                    map.print();
                    zmeya.move();
                } while (true);
            }
            catch(ApplicationException e)
            {
                Console.Clear();
                Console.WriteLine("Game Over");
                Console.WriteLine(e.Message);
            }

        }
    }
}
