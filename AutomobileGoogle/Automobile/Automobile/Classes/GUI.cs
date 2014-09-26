using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    partial class Auto
    {
		/// <summary>
		////Как видно из названия, рисует автомобиль:-)
		/// </summary>
        // void CarDrawing()
        //{
        //    Console.WriteLine("                                 _..-------++._");
        //    Console.WriteLine("                             _.-\'/ |      _||  \\\"--._");
        //    Console.WriteLine("                       __.--\'`._/_\\j_____/_||___\\    `----.");
        //    Console.WriteLine("                  _.--\'_____    |          \\     _____    /");
        //    Console.WriteLine("                _j    /,---.\\   |        =o |   /,---.\\   |_");
        //    Console.WriteLine("               [__]==// .-. \\\\==`===========/==// .-. \\=[__]");
        //    Console.WriteLine("                 `-._|\\ `-' /|___\\_________/___|\\ `-' /|_.'");
        //    Console.WriteLine("                       `---\'                     `---\'");
        //}

        public void Print()
        {
			CarDrawing();
            Console.WriteLine("\tАвтомобиль\n\nПроизводитель: \t\t{0}\nМодель: \t\t{1}\nТип корпуса: \t\t{2}\nЦвет: \t\t\t{3}\nКоличество дверей: \t{4}", vendor, model, typeBody, color, countDoors);
			Console.WriteLine("Статус: \t\t{0}\nТекущая скорость: \t{1} км/ч\nТекущая передача КПП: \t{2}\nРучной тормоз: \t\t{3}\nПедали: \t\t{4}", GetStatus(), speed, GetGear(), GetHandBreak(), GetPedal());
			Console.WriteLine("Стоп сигналы: \t\t{0}", GetStops());
        }


/// <summary>
///Этот метод отдает CHAR обозначение передачи КПП 
/// </summary>
/// /// <returns> CHAR </returns>
		char GetGear()
		{
			char gear = ' ';

			for (int i = 0; i < gears.Length; i++)
			{
				if (gears[i])
				{
					switch (i)
					{
						case 0:
							gear = 'R';
							break;
						case 2:
							gear = '1';
							break;
						case 3:
							gear = '2';
							break;
						case 4:
							gear = '3';
							break;
						case 5:
							gear = '4';
							break;
						case 6:
							gear = '5';
							break;
						default:
							gear = 'N';
							break;
					}
				}
			}
			return gear;
		}
		/// <summary>
		//// Этот метод отдает STRING обозначение педали 
		/// </summary>
		/// <returns> STRING </returns>
		string GetPedal()
		{
			string activePedal = "Все отжаты ";
			for (int i = 0; i < pedals.Length; i++)
			{
				if (pedals[i])
				{
					switch (i)
					{
						case 0:
							activePedal = "Зажато сцепление";
							break;
						case 1:
							activePedal = "Зажат тормоз";
							break;
						default:
							activePedal = "Зажат газ";
							break;
					}
				}
			}
			return activePedal;
		}

        string GetHandBreak()
        {            
			return (handBreak) ? "Зажат" : "Отжат";
        }

		string GetStops()
		{			
			return (stops) ? "Горят" : "Не горят";
		}

		string GetStatus()
		{
			return (status == "stopping")?"Автомобиль заглушен": "Автомобиль заведен";
		}
    }
}
