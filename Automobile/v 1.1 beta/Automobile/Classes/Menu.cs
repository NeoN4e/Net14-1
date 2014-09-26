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
            //int tmp;
            //do
            //{
            //   if (status == "stopping")
            //        Console.WriteLine("\n\nМеню:\n1 - Завести мотор\n2 - нажать педаль газа\n3 - Нажать педаль тормаза\n4 - нажать педаль сцепления\n5 - Сменить передачу\n6 - ручник");
            //    else
            //        Console.WriteLine("\n\nМеню:\n1 - Заглушить мотор\n2 - нажать педаль газа\n3 - Нажать педаль тормаза\n4 - нажать педаль сцепления\n5 - Сменить передачу\n6 - ручник");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //
            //} while (tmp < 1 && tmp > 6);
                        
            string[] menu = new string[6] { "Завести мотор", "Нажать педаль газа", "Нажать педаль тормаза", "Нажать педаль сцепления", "Сменить передачу", "Ручник" };
            int current = 0, count = menu.Length;

            do
            {
                
                Console.Clear();
                if (status == "stopping")
                    menu[0] = "Завести мотор";
                else
                    menu[0] = "Заглушить мотор";

                Print();
                Console.WriteLine("\n\n\t\t\t Меню: \n\n");

                for (int i = 0; i < count; ++i)
                {
                    Console.Write("\t\t");

                    if (current == i)
                        Console.Write("\b\b\b\b--> ");

                    Console.WriteLine(menu[i]);

                }
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
