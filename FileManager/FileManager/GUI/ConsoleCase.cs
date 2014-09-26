using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store;

namespace ConsoleGui
{   
    partial class GUI
    {
        public static string MenuName { get; set; }
        public static int CurrentChose { get; set; }

        /// <summary>
        /// Вывести на экран Меню выбора
        /// </summary>
        /// <param name="menu">Массив строк меню</param>
        /// <param name="currentPosition">Текущая позиция курсора в меню</param>
        protected static void ConsolePrintMenu(string[] menu)
        {
            Console.WriteLine(MenuName);
            for (int i = 0; i < menu.Length; i++)
            {
                if ((i + 1) == CurrentChose)
                    Console.WriteLine("---> {0} - {1} <---", (i + 1), menu[i]);
                else
                    Console.WriteLine("     {0} - {1}     ", (i + 1), menu[i]);
            }

            Console.WriteLine();
            if (CurrentChose == 0)
                    Console.WriteLine("---> 0 - Назад <---");
            else
                    Console.WriteLine("     0 - Назад     ");
        }

        /// <summary>
        /// Выбирает пункт меню
        /// </summary>
        /// <param name="args"></param>
        /// <returns>Возвращает номер выбраного пункта или 0- назад</returns>
        static public int ConsoleCase(params string[] args)
        {
            CurrentChose = 1;
            int CurrentRow = Console.CursorTop;

            ConsolePrintMenu(args);

            do
            {
                /* принимаем и проверяем нажатие клавиши */
                var key = Console.ReadKey();
                Console.CursorLeft = 0;
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        //Очистка экрана от мусора
                        Console.Clear();
                        Console.CursorTop = CurrentRow;
                        return CurrentChose; 
                    case ConsoleKey.UpArrow:
                        CurrentChose--;
                        if (CurrentChose < 0) CurrentChose = args.Length;
                        break;
                    case ConsoleKey.DownArrow:
                        CurrentChose++;
                        if (CurrentChose > args.Length) CurrentChose = 0;
                        break;
                }

                Console.CursorTop = CurrentRow;
                ConsolePrintMenu(args);

            } while (true);

            //return CurrentChose;
        }
    
        /// <summary>
        /// Меню выбора объекта
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        static public int ConsoleCase(object[] obj)
        {

            string[] strArr = new string[obj.Length];
            
            for (int i = 0; i < obj.Length; i++)
            {
                strArr[i] = obj[i].ToString();
            }

            return ConsoleCase(strArr);
            
        }
    }
}
