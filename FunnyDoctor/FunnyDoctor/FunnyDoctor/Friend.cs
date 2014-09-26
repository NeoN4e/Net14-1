using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyDoctor
{

    class Friend
    {
        /// <summary>Лечение народными средствами</summary>
        private bool Heal(Patient P)
        {

            Console.WriteLine("Друг чегото налечил");

            P["Температура"] = BoolRandom.GenRandStatus();
            P["Живот"] = BoolRandom.GenRandStatus();
            P["Перелом"] = BoolRandom.GenRandStatus();

            return true;
        }

        /// <summary>Осмотр у друга</summary>
        /// <returns>Делегат вариант лечения</returns>
        public HealProcedure Osmotr(Patient P)
        {
            return Heal;
        }
    }

}
