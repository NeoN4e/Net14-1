using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    partial class Auto
    {
    // свойство "Стопы" Юрий Коваленко
        public bool Stops
        {
           set {stops = value;}
            get
            {
                return stops;
              //Console.WriteLine("горят стопы");
            }
         }

    }
}