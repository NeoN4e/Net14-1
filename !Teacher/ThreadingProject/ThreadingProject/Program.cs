using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingProject
{
    class Test
    {
        public static object locker = new object();
        static double a=8;
        static double b=9;
        public static void FuncTest()
        {
            Console.WriteLine("1");
            lock (locker)
            {

                if (b != 0)
                    Console.WriteLine(a / b);
                //b=0;
                Thread.Sleep(3000);
            }
       

        }
       

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            
           /* Thread t = new Thread(Test.FuncTest);
            t.Start();
          
            new Thread(Test.FuncTest).Start();*/
           

            //Thread t = new Thread(TestMethod);
            //t.Start();
            ////Thread t2 = new Thread(TestMethod1);
            ////t2.Start();
            //while (true)
            //{
            //    Console.WriteLine("@");
            //    Thread.Sleep(1000);
            //}
            
           // new Thread(Func).Start();
           //// Func();
           // new Thread(Func).Start();


            //ParameterizedThreadStart p = new ParameterizedThreadStart(TestMethod);
            //new Thread(p).Start(1);
            //new Thread(p).Start(2);

            //Thread tt = new Thread(Func);
          
            //tt.Start();
            ////tt.Join();
            
            //Console.WriteLine("End child thread!!!!!");

            

        }

        static void Func()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + " " + DateTime.Now.Millisecond);
                Thread.Sleep(1000);
            }
           // Thread.CurrentThread.Join();
        }

        static void TestMethod(object s)
        {
           
            while (true)
            {
                Console.WriteLine("$" + (int)s);
                Thread.Sleep(5000);
            }
        }
        static void TestMethod()
        {
            while (true)
            {
                Console.WriteLine("$");
                Thread.Sleep(1000);
            }
        }

        static void TestMethod1()
        {
            while (true)
            {
                Console.WriteLine("+");
                Thread.Sleep(1000);
            }
        }
    }
}
