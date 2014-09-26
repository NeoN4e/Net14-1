using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carians
{
    class MausoleumAtHalicarnassus
    {
        string name = "Мавзолей в Галикарнасе";
        string country = "Галикарнас (на юго-западе Турции)";
        string description = "был возведен как надгробный памятник карийского правителя Мавсола его женой — царицей Артемисией";

        public override string ToString()
        {
            return String.Format("{0} расположена {1} \n {2}", name, country, description);
        }
    }
}
