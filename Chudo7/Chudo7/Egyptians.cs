using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egyptians
{
    class GreatPyramidOfGiza
    {
        string name = "Пирамида Хеопса";
        string country = "Гиза (Египет)";
        string description = "гробница фараона Хеопса";

        public override string ToString()
        {
            return String.Format("{0} расположена {1} \n {2}",name,country,description);
        }
    }

}
