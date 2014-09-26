using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyDoctor
{
    static class BoolRandom
    {
        static Random R = new Random();
        static public bool GenRandStatus()
        {
            if (R.Next(10) > 6) return true;
            return false;
        }
    }
}
