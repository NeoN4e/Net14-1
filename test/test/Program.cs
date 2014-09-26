using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{

    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine(Foo("Original string"));

            //float num;
            //num = 0 / 0.0F;
            //Console.WriteLine(num);


            {
                //  if (true)
                //  {
                int i = 1;
                //  }
            }

             int i = 2; 
            //Console.WriteLine(i); 
        }

        public static string Foo(string str)
        {
            try
            {
                return str;
                Console.WriteLine("1231231");
            }
            finally
            {
                Console.WriteLine("In finally");
                str = "Somewhere in finally";
            }
        }


    } 

}
