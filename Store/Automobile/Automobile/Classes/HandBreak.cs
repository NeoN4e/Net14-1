using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    partial class Auto
    {
        //Устанавливать / снимать ручник (handBreak)
        public void HandBreak()
        {
            if (handBreak == true)
            {
                handBreak = false;
                stops = false;
            }
            else
            {
                handBreak = true;
                stops = true;
                speed = 0;
            }
        }
        
    }
}
