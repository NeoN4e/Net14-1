using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    

    partial class Auto
    {

        public void Gas()
        {
            if (status == "starting")
            {
                int gearStatus = 1;
                for (int i = 0; i < gears.Length; i++)
                {
                    if (gears[i])
                    {
                        gearStatus = i;
                        break;
                    }
                }

                if (gears[0] != true)
                {
                    int addSpeed = 0;
                    switch (gearStatus)
                    {
                        case 1:
                            { addSpeed = 0; } break;
                        case 2:
                            { addSpeed = 1; } break;
                        case 3:
                            { addSpeed = 2; } break;
                        case 4:
                            { addSpeed = 3; } break;
                        case 5:
                            { addSpeed = 4; } break;
                        case 6:
                            { addSpeed = 5; } break;
                        default:
                            break;
                    }
                    speed += addSpeed;
                }
                else
                    speed = -1;
            }
            else
                speed = 0;
            
        }

    }
}
