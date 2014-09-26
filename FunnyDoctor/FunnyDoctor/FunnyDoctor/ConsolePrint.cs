using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyDoctor
{
    
    abstract class ConsolePrint
    {
       /// <summary>Выводит в окно консоли цветной текст</summary>
        public static void ColorWrite(string s, ConsoleColor color)
       {
           Console.ForegroundColor=color;
           Console.Write(s);
           Console.ResetColor();
       }
    }
}
