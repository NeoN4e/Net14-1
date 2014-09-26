using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruzchik
{
    /// <summary>Точка назначения ящика</summary>
    public struct XPoint
    {
        public override string ToString()
        { return "X"; }
    }

    /// <summary>Ящик</summary>
    public struct Box
    {
        public override string ToString()
        { return "@"; }
    } 
}