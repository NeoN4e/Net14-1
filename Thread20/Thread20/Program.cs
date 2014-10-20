using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread20
{
    class Program
    {
        // Используем уникальное имя приложения,
        // например, с добавлением имени компании
    //    static Mutex mutex = new Mutex(false,"1");

    //    static void Main()
    //    {
    //        try
    //        {
    //            // Ожидаем получения мьютекса 5 сек – если уже есть запущенный
    //            // экземпляр приложения - завершаемся.
    //            if (!mutex.WaitOne(TimeSpan.FromSeconds(5), false))
    //            {
    //                Console.WriteLine("В системе запущен другой экземпляр программы!");
    //                Console.ReadLine();
    //                return;
    //            }

    //            try
    //            {
    //                Console.WriteLine("Работаем - нажмите Enter для выхода...");
    //                Console.ReadLine();
    //            }
    //            finally { mutex.ReleaseMutex(); }
    //        }
    //        catch (Exception ex)
    //        { Console.WriteLine(ex.Message); }
    //    }


        static Semaphore s = new Semaphore(5,6);  // Available=3; Capacity=3

        static void Main()
        {
            for (int i = 0; i < 3000; i++)
            {
              //  Console.WriteLine("before"+i);
                new Thread(Go).Start(i);
                //Thread.Sleep(100);

              //  Console.WriteLine("after"+i);
            }
        }

        static void Go(object ob)
        {
            Console.WriteLine("begin "+ob);
            while (true)
            {
                
                s.WaitOne();
                Console.WriteLine("wait "+ob+ " "+DateTime.Now.Millisecond);
                // Только 3 потока могут находиться здесь одновременно
               // Thread.Sleep(100);
               // s.Release();
            }
            Console.WriteLine("end " + ob);
        }

    }
      
}
