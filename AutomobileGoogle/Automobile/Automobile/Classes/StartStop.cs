using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    
    partial class Auto {
 
        public void StartStop() {
            if (!this.fuel)
            {
                Console.Write("Нет бензина, завести не удасться !");
            }
            else {
                this.status = (this.status == "starting") ? "stopping" : "starting";
                Console.Write("Завелись, можно ехать");
            }
        }
    }
}
