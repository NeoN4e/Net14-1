using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Automobile
{    
    partial class Auto
    {
        //bool[] pedals = new bool[3] { false, false, false };
        //string status = "stopping";
        //bool[] gears = new bool[7] { false, true, false, false, false, false, false };
        //bool handBreak = false;
        //int speed = 0;

         public void Gas()
        {
            uint speedLimit = 150;
            if (status == "starting")
            {
                #region  // определение включенной передачи
                int gearStatus = 1;
                for (int i=0; i < gears.Length; i++)
                {
                    if (gears[i] == true)
                        gearStatus = i;
                }
               

                int addSpeed = 0;
                switch (gearStatus)
                {
                    case 0:
                        {
                            if (speed > 0)
                            speed = 0;
                            else if (speed > -10)
                                addSpeed = -1;
                        } break;

                    case 2:
                        {
                            if (speed < 20)
                                addSpeed = 1;                            
                        } break;

                    case 3:
                        {
                            if (speed < 40)
                                addSpeed = 2;  
                        } break;

                    case 4:
                        {
                            if (speed < 80)
                                addSpeed = 3;  
                        } break;
                    case 5:
                        {
                            if (speed < speedLimit)
                                addSpeed = 4;  
                        } break;

                    case 6:
                        {
                            if (speed < speedLimit)
                                addSpeed = 5;  
                        } break;

                    default:
                        break;
                }
 #endregion

               // pedals [2] = true;  // нажатие педали газа

                if(gears[1])
                {
                    Console.WriteLine("Включите передачу!");
                    Thread.Sleep(2000);
                }
                else if (pedals[0] == true)
                {
                    Console.WriteLine("Отпустите педаль сцепления!");
                    Thread.Sleep(2000);
                }
                else if (pedals[1] == true)
                {
                    Console.WriteLine("Отпустите педаль тормоза!");
                    Thread.Sleep(2000);
                }
                else if (handBreak)
                {
                     Console.WriteLine("Снимите с ручного тормоза!");
                     Thread.Sleep(2000);
                }
                // задаем приращение скорости в соотв. с включенной передачей
                else
                    speed += addSpeed;  
            }


        }

    }
}