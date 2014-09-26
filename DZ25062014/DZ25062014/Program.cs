using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ25062014
{
    class Program
    {
        static void Main(string[] args)
        {
            { //Задача 1
                uint first = 0, second = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nВВедите диапазон чисел для поиска простых чисел");
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n введите 1-е число");
                first = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("\n введите 2-е число");
                second = Convert.ToUInt32(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.DarkYellow;

                int Count;
                for (; first <= second; first++)
                {
                    Count = 0;
                    for (int i = 1; i <= first && Count <= 3; i++)
                    {
                        if (first % i == 0)
                        {
                            Count++;
                        }
                    }

                    if (Count <= 2) Console.Write("\t " + first);
                }
                Console.WriteLine();
            }

            { // Задача 2 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nПоиск совершенных чисел ( сумма делителей = числу)");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                uint sum = 0;
                for (uint i = 1; i <= 10000; i++)
                {
                    sum = 0;
                    for (uint j = 1; j < i; j++)
                    {
                        if (i % j == 0) sum += j;
                    }

                    if (sum == i) Console.Write("\t " + i);
                }
                Console.WriteLine();
            }

            {//Задача
                uint sum = 0, a = 0;
                uint b;

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nВВедите число для расчета суммы цифр (a<100)");
                Console.Title = "Сумма цифр";
                a = Convert.ToUInt32(Console.ReadLine());
                sum = a / 10 + a % 10; // целое дельть на целое = целое ХИНТ :)
                Console.WriteLine("сумма чисел =" + sum);
                if (a / 10 > 0) { Console.WriteLine("К-во символов=2"); }
                else { Console.WriteLine("К-во символов=1"); }

                b = a / 10 + a % 10 * 10;

                Console.WriteLine("Акроним ="+b);
            }

        }
    }
}
