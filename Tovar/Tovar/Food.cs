using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tovar
{
    class Food : Tovar
    {
        public Food(string name, string vendor, double price, string description = "")
            : base(name, vendor, price, description)
        { }
        
    }
}
