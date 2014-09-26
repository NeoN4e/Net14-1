using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    partial class Auto
    {
        //static bool[] gears = new bool[7];
        //static bool[] pedals = new bool[3];
        //public int Speed { get; set; }
        //public Auto()
        //{
        //    gears = new bool[7] { false, true, false, false, false, false, false };
        //    pedals = new bool[3] { false, false, false };
        //    Speed = 0;
        //}
        //actions UP, DOWN, R, N  method returns number of gear
        public int GearShifting(string action)
        {
            action = action.ToUpper();
            if (pedals[0] == true)
            {
                for (int i = 0; i < gears.Length; i++)
                {
                    if (gears[i] == true)
                    {
                        if (action == "UP" && i == gears.Length - 1)
                        {
                            return i;
                        }
                        else if (action == "UP" && i != gears.Length - 1)
                        {
                            gears[i] = false;
                            gears[i + 1] = true;
                            return (i + 1);
                        }
                        else if (action == "DOWN" && i == 2)
                        {
                            return i;
                        }
                        else if (action == "DOWN" && i > 2)
                        {
                            gears[i] = false;
                            gears[i - 1] = true;
                            return (i - 1);
                        }
                        else if (action == "N")
                        {
                            gears[i] = false;
                            gears[1] = true;
                            return 1;
                        }
                        else if (action == "R" && gears[1] == true )   //set the gear to Neutral and slow the car down to 0 km/h
                        {
                            gears[1] = false;
                            gears[0] = true;
                            return 0;
                        }
                    }
                }
            }
            return 1;
        }
    }
}
