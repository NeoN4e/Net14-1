using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeks
{
    class StatueOfZeusAtOlympia
    {
        string name = "Статуя Зевса в Олимпии";
        string country = "Олимпия (Греция)";
        string description = "храмовая статуя в храме Зевса в Олимпии";

        public override string ToString()
        {
            return String.Format("{0} расположена {1} \n {2}", name, country, description);
        }
    }
}
