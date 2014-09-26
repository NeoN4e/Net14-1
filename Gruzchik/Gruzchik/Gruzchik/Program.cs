using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using GameAPI;

namespace Gruzchik
{

    class Program
    {
        static int BoxQty;
        
        /// <summary>Обработчик Столкновений</summary>
        static void map_OnCollision(GameAPI.GameMap map, GameAPI.Point p, object NewObj, object ExistObj)
        {
            if (NewObj is Herro && ExistObj is Box)
            {
                Herro h = (NewObj as Herro);

                //Если перед ящиком Крестик удалим ящик и крестик
                if (map[p.Move(h.Vektor)] is XPoint)
                {
                    map.Remove(p.Move(h.Vektor));
                    map.Remove(p);
                    BoxQty--;
                }
                else
                    //передвинем ящик
                    if (map.Add(p.Move(h.Vektor), ExistObj) != null)
                        map.Remove(p);

            }
       
        }

        /// <summary>Метод генерация и размещения яблочек</summary>
        static void RandomObjectInsert(Object Obj, GameMap m)
        {
            Point p;

            //Генерируем координаты пока не пусто
            do
            {
                p = new Point(MyRandom.R.Next(2, m.XSize - 2), MyRandom.R.Next(2, m.YSize - 2));
                //     Console.WriteLine(p);
            } while (m[p] != null);

            m.Add(p, Obj);
        }

        /// <summary>Добавляем Ящики и Кресты на карту</summary>
        static void addbox(GameMap map, int qty)
        {
            for (BoxQty = 0; BoxQty < qty; BoxQty++)
            {
                RandomObjectInsert(new Box(), map);
                RandomObjectInsert(new XPoint(), map);
            }
        }

        static void Main(string[] args)
        {
    
            while (true)
            {
                try
                { BeginGame(); }
                catch (GameAPI.GameWinExeption)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" You WIN");
                    Console.WriteLine(" Pres eny key To next level");
                    Console.ReadKey();
                    Console.ResetColor();
                }
                catch (GameAPI.GameOverExeption)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Your Game  is Over");
                    Console.WriteLine(" Pres eny key To next level");
                    Console.ReadKey();
                    Console.ResetColor();
                }
            }
    
        }

        static void BeginGame()
        {
            GameMap map = GameMap.LoadMapFromfile("Simple.map.txt");
            GameLogic.PrintMap(map);

            Console.WriteLine("Необходимо передвинуть все ящики @ на свои места Х");

            map.OnMapChange += GameLogic.PrintChangeOnMap;
            map.OnCollision += map_OnCollision;
            
            Herro hero = new Herro(new Point(2, 2)); //Создадим героя
            map.Add(hero.CurentPosition, hero); //Добавим героя на карту

            //Разбросаем ящики по карте
            addbox(map, 4);

            //Цикл считывания Клавиш
            while (BoxQty > 0)
            {
                ConsoleKey K = Console.ReadKey().Key;
                switch (K)
                {
                    case ConsoleKey.UpArrow:    hero.Vektor = MoveVektor.Top; break;
                    case ConsoleKey.DownArrow:  hero.Vektor = MoveVektor.Down; break;
                    case ConsoleKey.LeftArrow:  hero.Vektor = MoveVektor.Left; break;
                    case ConsoleKey.RightArrow: hero.Vektor = MoveVektor.Right; break;
                }

                hero.Move(map);
            }

            throw new GameWinExeption();
             
        }
    }

   
}
