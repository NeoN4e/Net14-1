using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ввести строку определить сколько цифр, Лат символов, рус символов
            {
                string str;
                int tmp;
                int CountNumber = 0, CountLat = 0, CountRus = 0, ElseCount = 0;
                str = Console.ReadLine();
                for (int i = 0; i < str.Length; i++)
                {

                    if (Char.IsNumber(str[i])) { CountNumber++; }
                    else
                    {
                        tmp = (int)str[i];
                        if ((tmp >= 1040 && tmp <= 1103) || (tmp == 1105) || (tmp == 1025)) CountRus++;
                        else
                        {
                            if (Char.IsLetter(str[i])) CountLat++;
                            else ElseCount++;
                        }
                    }

                    //  Console.WriteLine((int)str[i]);
                }
                Console.WriteLine("Цифр=" + CountNumber);
                Console.WriteLine("Рус=" + CountRus);
                Console.WriteLine("Лат=" + CountLat);
                Console.WriteLine("Проч=" + CountLat);
                // Char
            }

            {
                string str, tmp;
                string[] strArr;
                Console.WriteLine("ВВедите строку с пробелами");
                str = Console.ReadLine();

                //sub = str.Substring();
                //strArr = str.Split(' ');
                strArr = str.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                str = "";
                for (int i = 0; i < strArr.Length; i++)
                {

                    //Console.WriteLine(strArr[i]);
                    tmp = strArr[i].Trim();
                    if (tmp != "") str += tmp + ' ';
                }

                Console.WriteLine(str.TrimEnd() + '!');
            }

            {
                string str, tmp;
                string[] strArr;
                int count = 0;
                Console.WriteLine("ВВедите строку");
                str = Console.ReadLine();

                strArr = str.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                str = "";

                Console.WriteLine("Итого: " + strArr.Length + " слов");

            }

            {
                string str;
                Console.Write("Калькулятор");
                str=Console.ReadLine();

                int[] arr;
                arr = str.Split(new char[] { '(', ')', '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);   

            }

        }
    }
}
