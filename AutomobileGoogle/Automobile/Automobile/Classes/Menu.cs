 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    partial class Auto
    {
        public int Menu()
        {
            string[] menu = new string[9] { "Завести мотор", "Нажать педаль газа", "Нажать педаль тормаза", "Нажать педаль сцепления", "Увеличить передачу", "Понизить передачу", "Установить N", "Установить R", "Потянуть Ручник" };
            int current = 0, count = menu.Length, left = 0, right = 0, tmp = 0;

            do
            {
                Console.Clear();
                left = 25;  // Отступ слева для установки позиции курсора
                right = 30; // Отступ по строчкам для установки позиции курсора
             
                /* изменение выводимого текста в зависимости от состояния поля класса */
                if (status == "stopping")
                    menu[0] = "Завести мотор";
                else
                    menu[0] = "Заглушить мотор";

                if (pedals[2] == false)
                    menu[3] = "Нажать педаль сцепления";
                else
                    menu[3] = "Отпустить педаль сцепления";

                if (handBreak == true)
                    menu[8] = "Потянуть Ручник";
                else
                    menu[8] = "Отпустить Ручник";
                    
                /* перерисовка экрана */
                Console.ForegroundColor = ConsoleColor.Gray;
                Print();
                Console.SetCursorPosition(left - 2, right);
                Console.WriteLine("Меню:");
                right += 2;

                /* вывод элементов меню на экран и прорисовка указателей(--> <--) на текущий элемент меню */
                for (int i = 0; i < count; ++i)
                {
                    tmp = menu[i].Length / 2; 

                    if (current == i) 
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition((left - tmp) - 4, right);
                        Console.Write("--> ");
                        Console.Write(menu[i] + " <--");
                        right++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.SetCursorPosition(left - tmp, right);
                        Console.WriteLine(menu[i] + " ");
                        right++;
                    }
                }
                
                /* принимаем и проверяем нажатие клавиши */
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        return current + 1;
                    case ConsoleKey.UpArrow: --current;
                        break;
                    case ConsoleKey.DownArrow: ++current;
                        break;
                }
                if (current == -1)
                    current = count - 1;

                if (current >= count)
                    current = 0;

            } while (true);



        }
    }
}
