using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Babylonians
{
    class HangingGardensOfBabylon
    {
        string name = "Висячие сады Семирамиды";
        string country = "Вавилон (Ирак)";
        string description = "Были созданы для жены царя Навуходоносора II.";

        public override string ToString()
        {
            return String.Format("{0} расположен {1} \n {2}", name, country, description);
        }
    }
}
