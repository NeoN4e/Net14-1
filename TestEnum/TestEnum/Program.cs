using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEnum
{
    class Program
    {

        delegate void MyDelegat();

        static void Main(string[] args)
        {
            Console.WriteLine((int)Color.Blue);
            Console.WriteLine(Enum.GetName(typeof(Color),0));
            Console.WriteLine(typeof(Color));
            
        }


        enum Color {Red , Gren ,Blue}
        
    }
}
