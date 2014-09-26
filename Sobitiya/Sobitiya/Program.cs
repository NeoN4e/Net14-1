using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobitiya
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    ////Counter c = new Counter();

        //    ////Hendler1 h1 = new Hendler1();
        //    ////Hendler2 h2 = new Hendler2();

        //    //////c.MyEvent += h1.msg; // подписка на событие
        //    //////c.MyEvent += h2.msg; // подписка на 

        //    ////c.count();

        //    ////List<People> peoplelist = new List<People>
        //    ////{
        //    ////    new People("Иванов"),
        //    ////    new People("Петров"),
        //    ////    new People("Сидоров")
        //    ////};
        //    //People p1 = new People("Иванов");
        //    //People p2 = new People("Петров");
        //    //People p3 = new People("Сидоров");

        //    //p3.Event += p1.GetMsg; //p1.GetMsg - Будет слушать p3
            
        //    //p1.Event += p2.GetMsg; //p2.GetMsg - Будет слушать p1
        //    //p1.Event += p3.GetMsg; //p3.GetMsg - Будет слушать p1
            
        //    //p1.say("Ку всем! Меня кто слышит?\n");//p1 говорит
          
            
        //    //Console.WriteLine();
        //    ////p3.say("Ку");

        //    ////p3.Event -= p1.GetMsg; // p1 больше не слушает p3
        //    ////p3.Event += (People p) => { Console.WriteLine("Это Лямбда :)"); };
        //    ////p3.say("Тест Лябда");

        //    ////p3.Event -=;
        //    ////p1.Event = null;
        //    //Console.WriteLine();

        //    delegate void MyGelegate(int a);

                
        //}

        delegate void MyDelegate(bool a);
        static void MyMetod(bool a)
        {
            Random r = new Random();
            if (a) Console.WriteLine(r.Next(1,20));
            else Console.WriteLine(r.Next(1, 20));
        }

        static event MyDelegate MyEvent;

        static void Main(string[] args)
        {
            int choose = 0;
            do
            {
                Console.WriteLine("1 , 2, 3");
                //choose = Int32.Parse(Console.ReadLine());
                choose = Convert.ToInt32(Console.ReadLine());
                MyEvent += MyMetod;

                MyEvent(Convert.ToBoolean(choose));
            } while (choose != 0);
        }
    }

    class Counter
    {
        public delegate void MetodDelegate();

        public event MetodDelegate MyEvent;

        public void count()
        {

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
                if (i==25)
                { 
                    if (MyEvent != null) MyEvent(); 
                }
            }
        }
    }

    class Hendler1
    {
        public void msg()
        { Console.WriteLine(this + " пора считать 25"); }
    }

    class Hendler2
    {
        public void msg()
        { Console.WriteLine(this + " 25"); }
    }

    class People
    {
        public string fio { get; set; }
        public People(string fio)
        { this.fio = fio; }

        /// <summary>Метод говорить( генератор события)</summary>
        public void say(string msg="Всем Ку!")
        {
            Console.WriteLine("{0}:{1}",this.fio,msg);
            if (Event != null )Event(this);
        }

        // <summary>метод слушать (Обработчик события)</summary>
        public void GetMsg(People p)
        {
            //this.say(String.Format("{0}, я тебя отлично слышу :)",p.fio));
            Console.WriteLine("{0}>>{1}: И тебе КУ!",this.fio,p.fio);
        }

        /// <summary>Делегат принимающий сообщение</summary>
        public delegate void MyEventDelegate(People p);
        
        /// <summary>
        /// Событие ответ
        /// </summary>
        public event MyEventDelegate Event;
     
    }
}
