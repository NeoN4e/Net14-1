using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lydians
{
    class TempleOfArtemisAtEphesus
    {
        string name = "Храм Артемиды в Эфесе";
        string country = "Эфес (Турция)";
        string description = "был построен в честь богини Артемиды";

        public override string ToString()
        {
            return String.Format("{0} расположена {1} \n {2}", name, country, description);
        }

    }
}
