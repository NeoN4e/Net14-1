using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread2
{
    class Program
    {
            //1. Создать несколько потоков, выводящих на консоль в цикле свой hashcode. Посмотреть порядок вывода.
            //Добавить Sleep(1), Sleep(10), Sleep(0). Посмотреть изменения в порядке вывода. Закоментировать Sleep() и установить приоритеты потокам. Посмотреть изменения в порядке вывода.
            //2. Написать программу, демонстрирующую работу Join(): основной поток должен дожидаться окончания работы (не менее) 2-х потоков, потом продолжать работу. 
            //Конструктивно: дополнительные потоки должны предоставлять данные, необходимые для дальнейшей работы основного потока.
        static void Go(object ob)
        {
            Console.WriteLine("Start thread {0}", ob);
            for (int i = 0; i < 10; i++)
            {
               // Thread.Sleep(0);
                Console.WriteLine("    Thread {0} priority {1}", ob,Thread.CurrentThread.Priority);
            }

            Console.WriteLine("END thread {0}",ob);
        }
        static Random r = new Random();

        static int Rezalt = 0;
        static void Sum(object ob)
        {
            int rezalt=0;
            for (int i = (int)ob ; i < ((int)ob) + 10; i++)
            {
                rezalt += i;
            }

            lock((object)Rezalt)
            { Rezalt += rezalt; }
        }

        static void Main(string[] args)
        {
            //Thread item;
            //for (int i = 0; i < 5; i++)
            //{
            //    item = new Thread(Go);
            //    //item.Priority = (ThreadPriority)(4-i);
            //    //item.Priority = (ThreadPriority)r.Next(5);
            //    item.Start(i);
            //}


            //Go("main");

            Thread t1 = new Thread(Sum);
            Thread t2 = new Thread(Sum);

    
                t1.Start(1); 
                t2.Start(2);

                Console.WriteLine(t2.ThreadState);
                t2.Join();
                Thread.Sleep(1000);
                Console.WriteLine(t1.ThreadState);
                t1.Join();
            //Sum(1);
            //Sum(2);
            Console.WriteLine(Rezalt);
        }
    }
}
