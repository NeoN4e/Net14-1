using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    partial class Program
    {
        

        static void Main(string[] args)
        {
            Console.SetWindowSize(70, 35);

            //Хилько Юрий 
            Auto tarantas = new Auto();
            do
            {
                //Console.Clear();
                //tarantas.Print();
                //Console.WriteLine();
                switch (tarantas.Menu())
                {
                    case 1:
                        //метод работы с двигателем
                        tarantas.StartStop();
                        break;
                    case 2:
                        //метод работы с педалью газа
                        tarantas.Gas();
                        break;
                    case 3:
                        //метод работы с педалью тормаза
                        tarantas.Brake();
                        break;
                    case 4:
                        //метод работы с педалью сцепления
                        tarantas.Clutch();
                        break;
                    case 5:
                        //метод работы с передачами
                        Console.WriteLine("UP, DOWN, R, N");
                        tarantas.GearShifting(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("6+1");
                        //метод работы с ручником
                        tarantas.HandBreak();
                        break;
                    default:
                        Console.WriteLine("Ошибка! Введите цифру из пункта меню");
                        break;
                }
            }
            while (true);
        }
    }
}
