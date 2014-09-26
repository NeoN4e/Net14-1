using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] myArr = new int[10][];
            ////Console.WriteLine(myArr[3]);

            //Random r = new Random();
            //for (int i=0; i < myArr.GetLength(0); i++)
            //{
            //    myArr[i] = new int[i + 1];

            //    for (int j = 0; j < i+1; j++)
            //    {
            //        myArr[i][j] = r.Next(-100, 100 );
            //        Console.Write(myArr[i][j] + "\t");
            //    }
            //    Console.WriteLine();    
            //}

            Random r = new Random();
            int[][] myArr = new int[r.Next(2, 10)][];

            for (int i = 0; i < myArr.Length; i++)
            {
                int temp = r.Next(1, 10);
                myArr[i] = new int[temp];
                for (int j = 0; j < temp; j++)
                {
                    //Диапазон
                    myArr[i][j] = r.Next(-10, 10);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < myArr.Length; i++)
            {
                foreach (int item in myArr[i])
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            {
                //1. Преобразовать массив так, что бы сначала шли все отрицательные элементы, а потом положительные, 0 считать положительным.
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n1. Преобразовать массив так, что бы сначала шли все отрицательные элементы, а потом положительные, 0 считать положительным.");

                //int[][] arr = (int[][])myArr.Clone(); 
                //Array.Copy(myArr, arr, myArr.LongLength);
                int[][] arr = Program.CppyArr(myArr);

                for (int i = 0; i < arr.Length; i++)
                {
                    int count = 0;
                    int ArrLastInd = arr[i].Length - 1;

                    for (int j = 0; j <= ArrLastInd; j++)
                    {

                        if (arr[i][j] < 0)
                        {
                            int tmp = arr[i][j];
                            //Сдвигаем все элементы в право до тек позиции
                            for (int k = j; k > count; k--)
                            {
                                arr[i][k] = arr[i][k - 1];
                            }
                            arr[i][count] = tmp;
                            count++;
                        }
                    }
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    foreach (int item in arr[i])
                    {
                        Console.Write(item + "\t");
                    }
                    Console.WriteLine();
                }

            }

            {
                //2. Написать программу, которая предлагает пользователю ввести число и считает сколько раз это число встречается в массиве.
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n2. Написать программу, которая предлагает пользователю ввести число и считает сколько раз это число встречается в массиве.");

                //int[][] arr = (int[][])myArr.Clone();
                int[][] arr = Program.CppyArr(myArr);
                int a, count = 0;

                Console.ResetColor();
                Console.WriteLine("Введите число для поиска в массиве");
                a = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < arr.Length; i++)
                {
                    foreach (int item in arr[i])
                    {
                        if (item == a) count++;
                    }
                }

                //Вывлд массива
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine();
                Console.WriteLine("Число " + a + " встречаеться " + count + " раз");

            }
            {
                //3. Сжать массив, удалив из него все 0 и заполнить освободившиеся справа элементы значениями -1.
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n3. Сжать массив, удалив из него все 0 и заполнить освободившиеся справа элементы значениями -1.");

                //int[][] arr = (int[][])myArr.Clone();
                int[][] arr = Program.CppyArr(myArr);
                for (int i = 0; i < arr.Length; i++)
                {
                    int strLenght = arr[i].Length;
                    for (int j = 0; j < strLenght; j++)
                    {
                        //Если 0 меняем все последующие с этим
                        if (arr[i][j] == 0)
                        {
                            //перебираем до предпоследнего
                            for (int k = j; k < strLenght - 1; k++) { arr[i][k] = arr[i][k + 1]; }
                            arr[i][strLenght - 1] = -1;

                            j--;//Иключение когда 2 0 идут подряд
                        }
                    }
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    foreach (int item in arr[i])
                    {
                        Console.Write(item + "\t");
                    }
                    Console.WriteLine();
                }

            }

            {
                //4. В двумерном массиве порядка М на N поменяйте местами заданные столбцы
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n4. В двумерном массиве порядка М на N поменяйте местами заданные столбцы");

                Console.ResetColor();
                Console.WriteLine("\n Введите номера колонок");

                int first, second;
                first = Convert.ToInt32(Console.ReadLine());
                second = Convert.ToInt32(Console.ReadLine());

                //int[][] arr = (int[][])myArr.Clone();
                int[][] arr = Program.CppyArr(myArr);


                Console.ForegroundColor = ConsoleColor.DarkYellow;
                int tmp;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Length - 1 < second || arr[i].Length - 1 < first) Array.Resize(ref arr[i], Math.Max(first, second) + 1);

                    tmp = arr[i][first];
                    arr[i][first] = arr[i][second];
                    arr[i][second] = tmp;
                }
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    foreach (int item in arr[i])
                    {
                        Console.Write(item + "\t");
                    }
                    Console.WriteLine();
                }
            }

            //5. Даны два массива. Массив А состоит из N элементов и отсортирован по возрастанию. Массив В состоит из М элементов и отсортирован по убыванию.

            {
                //6. Найти два самых маленьких элемента в массиве. Указать их значения и индексы.
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n6. Найти два самых маленьких элемента в массиве. Указать их значения и индексы.");
                Console.ForegroundColor = ConsoleColor.Green;
                int[,] arr = new int[5, 10];
                //определим массив
                Console.WriteLine();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = r.Next(-10, 10);
                        Console.Write("\t" + arr[i, j]);
                    }
                    Console.WriteLine();
                }

                //Решение
                int min1, min2;
                string ind1 = "", ind2 = "";

                min1 = arr[0, 0];
                min2 = arr[0, 1];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] == min1) { ind1 += " (" + i + "," + j + ")"; }
                        if (arr[i, j] == min2) { ind2 += " (" + i + "," + j + ")"; }

                        if (arr[i, j] < min1) { min1 = arr[i, j]; ind1 = " (" + i + "," + j + ")"; }
                        if (arr[i, j] < min2 && arr[i, j] != min1) { min2 = arr[i, j]; ind2 = " (" + i + "," + j + ")"; }
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" 1-е Минимальное значение \t" + min1 + " \t" + ind1);
                Console.WriteLine(" 2-е Минимальное значение \t" + min2 + " \t" + ind2);

            }

            {
                //7. Дан массив А[n]. Каждый его элемент, кроме первого, заменить суммой всех предыдущих элементов (т.н. нарастающий итог).
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n7. Дан массив А[n]. Каждый его элемент, кроме первого, заменить суммой всех предыдущих элементов (т.н. нарастающий итог).");
                Console.ForegroundColor = ConsoleColor.Green;

                //определим массив
                int[] arr = new int[10];
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = r.Next(1, 10);
                    Console.Write("\t" + arr[i]);
                }

                //решение
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    arr[i] = 0;
                    for (int j = 0; j < i; j++) arr[i] += arr[j];
                }

                //ответ
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                foreach (int item in arr) { Console.Write("\t" + item); }
            }
            {
                //8. Каждый из элементов X[i] массива X[n] заменить средним значением первых i элементов этого массива (т.н.задача текущего сглаживания).
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n8. Каждый из элементов X[i] массива X[n] заменить средним значением первых i элементов этого массива (т.н.задача текущего сглаживания).");
                Console.ForegroundColor = ConsoleColor.Green;
                //определим массив
                double[] arr = new double[10];
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = r.Next(1, 10);
                    Console.Write("\t" + arr[i]);
                }

                //решение
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    arr[i] = 0;
                    for (int j = 0; j < i; j++) arr[i] += arr[j];
                    arr[i] = arr[i] / i;
                }

                //ответ
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                foreach (double item in arr) { Console.Write("\t" + item); }

            }

            {
                //9. Проверить, является ли заданный двумерный массив магическим квадратом. (Суммы элементов всех строк, всех столбцов и обеих диагоналей в таком массиве одинаковы ).
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n9. Проверить, является ли заданный двумерный массив магическим квадратом. (Суммы элементов всех строк, всех столбцов и обеих диагоналей в таком массиве одинаковы ).");
                Console.ForegroundColor = ConsoleColor.Green;
                //определим массив
                int[,] arr = new int[5, 5];
                Console.WriteLine();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = r.Next(1, 10);
                        Console.Write("\t" + arr[i, j]);
                    }
                    Console.WriteLine();

                }

                //Решение
                bool Rezalt = true;
                int strSum = 0, diag1Sum = 0, diag2Sum = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    int curStrSum = 0;
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        curStrSum += arr[i, j];
                    }

                    diag1Sum += arr[i, i];
                    diag2Sum += arr[arr.GetLength(0) - 1 - i, i];

                    //Пррерка
                    if (i == 0) strSum = curStrSum;

                    if (strSum != curStrSum) { Rezalt = false; break; }
                }

                if (!(diag1Sum == diag2Sum && strSum == diag1Sum)) { Rezalt = false; }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                if (Rezalt == true) Console.WriteLine("МАГИЧЕСКИЙ КВАДРАТ :)");
                else Console.WriteLine("Просто обычный массив :(");
            }

            {
                //10. В заданном двумерном массиве найти индекс строки, сумма элементов которой максимальна. 
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n10. В заданном двумерном массиве найти индекс строки, сумма элементов которой максимальна. ");
                Console.ForegroundColor = ConsoleColor.Green;
                //определим массив
                int[,] arr = new int[5, 5];
                Console.WriteLine();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = r.Next(1, 10);
                        Console.Write("\t" + arr[i, j]);
                    }
                    Console.WriteLine();

                }

                //Решение
                int sum=0, MaxSum=0, ind=0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    sum = 0;
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        sum += arr[i,j];
                    }

                    if (i == 0) MaxSum = sum;

                    if (sum >= MaxSum) { MaxSum = sum; ind = i; }
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Макс сумма в строке " + ind + " и равна=" + MaxSum);

            }
            Console.WriteLine();
        }
        
        static int[][] CppyArr(int[][] myArr)
        {
            int[][] arr = new int[myArr.Length][];

            for (int i = 0; i < myArr.Length; i++)
            { 
                arr[i]=new int [myArr[i].Length];
                for (int j = 0; j < myArr[i].Length; j++)
                {
                    arr[i][j] = myArr[i][j];
                }
            }
            return arr; 
        }
    }
}
