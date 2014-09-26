using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   partial class Program
    {
        static void Main(string[] args)
        {
            //Program g = new Program();
           /* if (args.Length > 0)
            {
                if (args[0] == "11111")
                {
                    foreach (var i in args)
                    {
                        Console.WriteLine(i);
                    }
                    return;
                }
            }
            else
                Program.Main(new string[] { "11111" });*/
           
            //Random r = new Random();
            //List <Student>st = new List<Student>();
            //for (int i = 0; i < 5; i++)
            //{
            //    st.Add (new Student(r));
            //}
            //Student.StudentPrint(st);
            //Console.WriteLine(Student.CountStudent);
            //char choose;
            //do
            //{
            //    Console.WriteLine("Хотите добавить студента?(y/n)");
            //    choose = Convert.ToChar( Console.ReadLine());
            //    if (choose == 'y')
            //    {
            //        if (Student.CountStudent < 12)
            //        {
            //            st.Add(new Student(r));
            //            Console.Clear();
            //            Student.StudentPrint(st);
            //        }
            //        else
            //        {
            //            Console.WriteLine("невозможно добавить стдентаБ количество ограничено");
            //            break;
            //        }
            //    }
            //    else
            //        break;
            //}while(true);
          //  Console.WriteLine(Sum(12,"qwerty",1, 2, 3, 4, 5, 6, 7, 8));
            Class1.Show(true);
        }

        public static int Sum(int q, string str,params int[] arr)
        {
            Console.WriteLine(q);
            Console.WriteLine(str);
            int res = 0;
            foreach (var i in arr)
            {
                res += i;
            }
            return res;
        }

    }
}
