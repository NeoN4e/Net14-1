using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameAPI;

namespace Gruzchik
{
    abstract class GameLogic
    {
        /// <summary>Загружает карту из случайного файла .map</summary>
        public static GameMap RandomMapLoad(string Dir)
        {
            String[] maps = Directory.GetFiles(Dir, "*.map");
            return GameMap.LoadMapFromfile(maps[MyRandom.R.Next(maps.Length)]);
        }

        /// <summary>Выводит на экран карту</summary>
        public static void PrintMap(GameMap map)
        {
            Console.Clear();

            Console.Write(new String('.', map.XSize + 2));
            Console.Write("\n.");

            uint iterator = 0;

            //Все обьекты на карте
            foreach (var item in map)
            {

                if (item == null) Console.Write(" ");
                else
                    Console.Write(item);

                //переход на новую строку при кво элементов Больше чем в строке карты
                if (++iterator >= map.XSize)
                {
                    iterator = 0;
                    Console.Write(".\n.");
                }
            }

            Console.Write(new String('.', map.XSize + 1));
            Console.WriteLine();
        }

        /// <summary>Отрисовывает изменения карты </summary>
        public static void PrintChangeOnMap(GameMap map, Point p)
        {
            Console.SetCursorPosition(p.X + 1, p.Y + 1);

            Object item = map[p];
            if (item == null) Console.Write(" ");
            else
                Console.Write(item);

            Console.SetCursorPosition(0, map.YSize + 3); //Затычка необходимо убрать курсор с карты
        }
    }

    /// <summary>Бесконечно считывает нажатие клавиш</summary>
    public abstract class KeyReader
    {
        public delegate void DelegateOnKeyPress(ConsoleKey K);
        static public event DelegateOnKeyPress OnKeyPress;

        static public void ReadKey()
        {
            while (true)
            {
                ConsoleKey K = Console.ReadKey().Key;
                if (OnKeyPress != null) OnKeyPress(K);
            }

        }
    }
}
