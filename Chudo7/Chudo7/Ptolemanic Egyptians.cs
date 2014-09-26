using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtolemanicEgyptians
{
    class LighthouseOfAlexandria
    {
        string name = "Александрийский маяк";
        string country = "греки Династия Птолемеев";
        string description = "свет этого маяка был очень полезен для судоходства.";

        public override string ToString()
        {
            return String.Format("{0} расположена {1} \n {2}", name, country, description);
        }
    }
}