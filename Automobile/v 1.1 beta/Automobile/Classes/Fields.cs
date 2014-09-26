using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    partial class Auto
    {
        string vendor = "ВАЗ";
        string model    = "2101";
        string typeBody = "Седан";
        string color    = "Гнилая вишня";
        string status   = "stopping";
        int countDoors  = 4;
        int speed       = 0;
        
        bool stops      = false;
        bool[] pedals   ={false,false,false};//3
        bool fuel       = true;
        bool handBreak  = true;
        bool[] gears    ={false,true,false,false,false,false,false};//R N 1 2 3 4 5

    }
}
