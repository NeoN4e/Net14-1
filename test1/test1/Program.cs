using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //test o = new test();
        }
    }

    abstract class test 
    {
        virtual public void print();
    }

    class test2 : test
    {
        public override void print()
        {
            throw new NotImplementedException();
        }
    }
}
