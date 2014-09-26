using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekyrsia
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            //Console.WriteLine(Pow(2, r.Next(10)));
            //Console.WriteLine(fact(4));
            Console.WriteLine(SumDiap(1, 5));

            Console.WriteLine("ВВедите число");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("В числе "+QTY(a)+" цифр");
            Console.WriteLine("Сумма цифр " + SumCifr(a) + " цифр");
            Console.WriteLine("Обратно " + Convert.ToInt32(Back(a)) + " цифр");

            int[] myArr = new int[5];
            GetRandArr(myArr);
            PrintArr(myArr);
            Console.WriteLine("\n ВВедите искомое число");
            
            int input= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" " + FindValInArr(myArr, input));
        }

        static public string FindValInArr(int[] arr,int val,int index=0)
        {
            string rez="";

            if (index >= arr.Length) return "";
            if (arr[index] == val) rez=Convert.ToString(index)+",";

            return rez+FindValInArr(arr, val, index + 1);
        }

        static public void PrintArr(int[] arr)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\t" + arr[i]);
            }
            Console.WriteLine();
            Console.ResetColor();
            
        }

        static public int[] GetRandArr(int[] arr)
        {
            Random r = new Random();
            for(int i=0; i<arr.Length; i++)
            {
                arr[i]=r.Next(-10,10);
            }

            return arr;
        }

        static public String Back(int a)
        {
            if (a / 10 == 0) return Convert.ToString(a % 10);
            else //return ""+Back(a / 10) + a % 10;
            {
                return (a % 10)+Back(a / 10);
            }
        }

        static public int SumCifr(int a)
        {
            if (a/10 ==0) return a%10;
            else return a%10+SumCifr(a/10);
        }

        static public int QTY(int a)
        {
            if (a < 10) return 1;
            else return 1 + QTY(a / 10);
        }

        static public int SumDiap(int a, int b)
        {
            if (a > b) return 0;
            if (a == b) return a;
            else return a+b+ SumDiap(a + 1, b-1);
        }

        static public int Pow(int num, int st = 1)
        {
            if (st == 0) return 1;
            
            if (st == 1) return num;
            else return num * Pow(num, st - 1);

        }

        static public int fact(int num)
        {
            if (num == 0 || num == 1) return 1;
            else return num * fact(num - 1);
        }
    }
}
