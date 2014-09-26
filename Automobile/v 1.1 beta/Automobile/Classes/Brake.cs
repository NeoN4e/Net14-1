// часть класса Auto, с реализацией метода Brake() - снижение скорости
// Юрий Коваленко
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    partial class Auto
    {
        public void Brake()
        {
            this.pedals[1] = true;
            this.Stops = true;
            if (this.speed >= 5)
            {
                this.speed -= 5;
            }
            else
            {
                this.speed = 0;
            }
        }

    }
}
