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
        //(С)Антон Коноваленко
        public void HandBreak()
        {
            if (handBreak == true) handBreak = false;
            else
            { 
                handBreak = true;
                speed = 0;
            }
        }
        
    }
}
