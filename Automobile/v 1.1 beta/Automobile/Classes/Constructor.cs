// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automobile
{
   partial class Auto
    {
      

       public Auto (/*string v, string m, string tB, string c, int cD*/)
       {
           // Прием параметров в конструкторе
           //vendor = v;
           //model = m;
           //typeBody = tB;
           //color = c;
           //countDoors = cD;

           speed = 0;
           status = "stopping";
           stops = false;
           pedals = new bool[] { false, false, false };
           fuel = true;
           handBreak = true;
           gears = new bool []{false, true, false, false, false, false, false };
           }
    }
    
}
