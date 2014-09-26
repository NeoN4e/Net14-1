using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проверка на точность
            //1. Напишите программу, проверяющую число, введенное с клавиатуры на четность.
            //Например, ввели число 17, на экран выводится - число нечетное.
          
            uint var = 0;
            Console.WriteLine("ВВедите число для проверки на четность");
            Console.Title = "Проверка на четность";
            Console.WriteLine();

            var = Convert.ToUInt32(Console.ReadLine());
            if (var == 0) { Console.WriteLine(" 0 - НЕ есть четным или не четным"); }
            else
            {
                if (var % 2 == 0) Console.WriteLine("Число Четноё");
                else Console.WriteLine("Число не четное");
            }
    
            //2. Дано натуральное число а (a<100). Напишите программу, выводящую на экран количество цифр в этом числе и сумму этих цифр.
            //Например, ввели 34 на экран выводиться в числе цифры 2, сумма равна 3+4=7
                //version 1.
                //uint sum = 0;
                //string str;
                //Console.ForegroundColor = ConsoleColor.Blue;
                //Console.WriteLine("\nВВедите число для расчета суммы цифр");
                //Console.Title = "Сумма цифр";

                //str = Console.ReadLine();
                //Console.WriteLine("К-во символов = " + str.Count());
                //for (int i = 0; i < Convert.ToInt32(str.Count()); i++)
                //{
                //    //Console.WriteLine(str.Substring(i,1));
                //    sum += Convert.ToUInt32(str.Substring(i, 1));
                //}
                //Console.WriteLine("Сумма чисел =" + sum);

                uint sum = 0, a=0;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nВВедите число для расчета суммы цифр (a<100)");
                Console.Title = "Сумма цифр";
                a = Convert.ToUInt32(Console.ReadLine());
                sum = a / 10 + a % 10; // целое дельть на целое = целое ХИНТ :)
                Console.WriteLine("сумма чисел ="+sum);
                if (a / 10 > 0) { Console.WriteLine("К-во символов=2");}
                else { Console.WriteLine("К-во символов=1"); }

            //3. Известно, что 1 дюйм равен 2.54 см. Разработать приложение, переводящие дюймы в сантиметры и наоборот. Диалог с пользователем реализовать через систему меню.
            //Например, сразу на экран выводиться текст примерно такого содержания:
            //1- переводим в дюймы
            //2 - переводим в сантиметры
            //Выберите действие
            //после пользователь вводит 1 или 2 и соответственно запрашивается если выбрал 1 введите сантиметры, если 2 - введите дюймы, после этого выводится результат

            const double duim = 2.54;
            double input=0;
            string chose;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Title="Конвертор ДЮЙМОВ";

            Console.WriteLine();
            Console.WriteLine("1 -перевод в Дюймы ");
            Console.WriteLine("2 -перевод в Сантиметы");
            Console.ForegroundColor = ConsoleColor.Yellow;

            chose = Console.ReadLine();
            
            Console.WriteLine("Введите конвертируемое число");
            input=Convert.ToDouble(Console.ReadLine());
            switch(chose)
            {
                case "1": Console.WriteLine("" + input + " см.=" + (input / duim) + " дюймов"); break;
                case "2": Console.WriteLine("" + input + " дюймов=" + (input * duim) + " см."); break;
                default: Console.WriteLine("Вариант не предусмотрен"); break;       
            }

           
            //1. Напечатайте на экране 10 раз слово Hello.
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\n1. Напечатайте на экране 10 раз слово Hello.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (int i = 0; i < 10; i++) Console.Write("\t HELLOW");
            //2. Напечатайте в столбик нечетные числа от 3 до 25.
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\n2. Напечатайте в столбик нечетные числа от 3 до 25.");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (int i = 3; i <= 25; i+=2) Console.WriteLine("\t\t"+i);

            //3. Напечатайте таблицу умножения на 5. предпочтительно печатать
            //1 x 5 = 5
            //2 x 5 = 10
            //а не просто 5, 10 и т.д.
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\n 3. Напечатайте таблицу умножения на 5. ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (int i = 1; i <= 10; i++) { Console.WriteLine("\t\t {0} \t x \t 5 = \t{1}", i, i * 5); }

            //4. Напишите программу, которая вычисляет сумму квадратов чисел от 1 до N. Число N программа должна запрашивать у пользователя.
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\n 4. Напишите программу, которая вычисляет сумму квадратов чисел от 1 до N. Число N программа должна запрашивать у пользователя.");
                

                uint N = 0;
                sum = 0; //переменная определенна выше
                Console.ResetColor();
                Console.WriteLine("ВВедите К-во символов ");
                N = Convert.ToUInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (uint i = 1; i <= N; i++) { sum += i * i; }
                Console.WriteLine("Сумма квадратов ={0}",sum);

            //5. С клавиатуры вводятся n чисел. Составьте программу, которая определяет кол-во отрицательных, кол-во положительных и кол-во нулей среди введеных чисел. Значение n вводится с клавиатуры.
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\n 5. С клавиатуры вводятся n чисел. Составьте программу, которая определяет кол-во отрицательных, кол-во положительных и кол-во нулей среди введеных чисел. Значение n вводится с клавиатуры. ");
                Console.ResetColor();
                
                uint сount,qtyPlus=0,qtyMinus=0;
                input = 0;//Double    
        
                Console.WriteLine(" сколько будет чисел?");
                сount = Convert.ToUInt32(Console.ReadLine());
                for (int i = 0; i < сount; i++)
                {
                    Console.WriteLine("Введите число");
                    input = Convert.ToDouble(Console.ReadLine());
                    if (input < 0) qtyMinus++;
                    if (input > 0) qtyPlus++;
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n Итого: " + qtyMinus + " Отрицательных " + qtyPlus + " Положительных " + (сount - qtyMinus - qtyPlus) + " нулей");

            //6. Найти минимальное число большее 300, которое делится на 19.
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\n 6. Найти минимальное число большее 300, которое делится на 19 ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                N = 300;
                do
                {
                    N++;
                } while (N % 19 != 0);
                Console.WriteLine("{0} / 19 = {1}",N,N/19.0);

            //7. Определить, является ли введенное пользователем число степенью тройки.
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\n 7. Определить, является ли введенное пользователем число степенью тройки. ");
            
                // uint N=0;
                N = 0; sum = 3;
                Console.ResetColor();
                Console.WriteLine("ВВедите Число");

                N = Convert.ToUInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                // uint сount;
                сount = 0;
                for (сount = 1; sum < N; сount++) { sum *= 3; }
                if (sum == N) { Console.WriteLine("Число " + N + "  " + сount + "-я степень число 3"); }
                else { Console.WriteLine("Число "+N+" не является степенью числа 3"); }

            //8. Напишите программу, которая запрашивает у пользователя числа до тех пор, пока каждое следующее число больше предыдущего. В конце программа сообщает, сколько чисел было введено.
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\n 8. Напишите программу, которая запрашивает у пользователя числа до тех пор, пока каждое следующее число больше предыдущего. В конце программа сообщает, сколько чисел было введено. ");
                int first=0, second=0;
                сount = 0;
                Console.ResetColor();
                do
                {
                    Console.WriteLine("\n Введите новое число");
                    second = Convert.ToInt32(Console.ReadLine());
                    if (second <= first) { break; } else { first = second; сount++; } 
                } while (true);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Было введено " + сount + " Чисел");

            //9. Даны натуральные числа от 20 до 50. Напечатать те из них, которые делятся на 3, но не делятся на 5.
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\n 9. Даны натуральные числа от 20 до 50. Напечатать те из них, которые делятся на 3, но не делятся на 5. ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                for (uint i = 20; i <= 50; i++)
                {
                    if (i % 3 == 0 && i % 5 != 0) { Console.Write("\t" + i); }
                }
                
            //10. Даны натуральные числа от 35 до 87. Найти и напечатать те из них, которые при делении на 7 дают остаток 1, 2 или 5.
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\n 10. Даны натуральные числа от 35 до 87. Найти и напечатать те из них, которые при делении на 7 дают остаток 1, 2 или 5. ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (uint i = 35; i <= 87; i++)
                {
                    if (i % 7 == 1 || i % 7 == 2 || i%7==5) Console.Write("\t" + i);
                }
        
        Console.WriteLine();
        }
    }
}
