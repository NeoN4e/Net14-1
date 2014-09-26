using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a;b;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Title = "Picasso :)";

            //const int n = 7;
            //const int m = 10;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (i == 0 || j == i || j==m-1 ) Console.Write("* ");
            //        //if (j == 0 || j == m-1 || i+j==n-1 ) Console.Write("* ");
            //        //if (j<=i) Console.Write("* ");
            //        else Console.Write("  ");
            //    }
            //    Console.WriteLine();
            //}

            const int s = 16;
            const int k = 16;

            //чысы 
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (i == 0 || i == s - 1 || j == s-1-i || j==i ) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (j == 0 || j == k-1 || j == s - 1 - i || j == i) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (i==0 || i==s-1 || j == 0 || j == k - 1 || j == s - 1 - i || j == i) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (i == s - 1 || j == 0 || j == i) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (i == 0 || j == k - 1 || j == i) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (i == 0 || j==0 || j+i==s-1) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (i == s-1 || j == k-1 || j + i == s - 1) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (j == (k / 2 + i) || (j == k / 2 - i) || (j == k / 2 - (s-1 - i)) || (j == k / 2 + (s-1 - i))) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if ((i == 0 && j > k / 2) || (i == s - 1 && j < k / 2) || (j == k / 2 - i / 2) || (j == k / 2 + (s-1-i) / 2)) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }

            //Крашенные треугольники
            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (j <= i) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
            
            //**
            // *
            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (j >= i) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (j >= s-1-i) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (j <= s - 1 - i) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }

            //крашенные часы
            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if ((j <= s - 1 - i && j >= i) || (j >= s - 1 - i && j <= i)) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }

            //крашенные часы бесконнечность
            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if ((j <= s - 1 - i  && j<=i)||(j >= s - 1 - i && j>=i))  { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }

            //крашенный ромб
            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j = k/2; j < k; j++)
                {
                    if ((j >= s - 1 - i && j >= i)) { Console.Write("* "); }
                    else Console.Write("  ");
                }
               for (int j = 0; j < k/2; j++)
               {
                   if ((j <= s - 1 - i && j <= i) ) { Console.Write("* "); }
                   else Console.Write("  ");
               }
                Console.WriteLine();
            }

            //крашенный паралелограмм
            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j =0; j < k; j++)
                {
                    if ((j >= s - 1 - i )) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                for (int j = 0; j < k ; j++)
                {
                    if (j<=s-1-i) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }

            //паралелограмм 2 вариант
            Console.WriteLine();
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if ((j == s - 1 - i)||i==s-1 ) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                for (int j = 0; j < k; j++)
                {
                    if (j == s - 1 - i||i==0) { Console.Write("* "); }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }
}
