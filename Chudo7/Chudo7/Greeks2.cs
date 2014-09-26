using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeks
{
    class ColossusOfRhodes
    {
        string name = "Колосс Родосский";
        string country = "Родос (Греция)";
        string description = "был установлен скульптором Харесом для увековечивания памяти о победе Родоса над Деметрием Полиоркетом (304 г. до н. э.) .";

        public override string ToString()
        {
            return String.Format("{0} расположена {1} \n {2}", name, country, description);
        }
    }
}
