using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace Uyility
{
    public static class Logger
    {
        public static void Log(string message)
        {
            File.AppendAllText("C:\\MyLogFile.txt", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + ":\t" + message + Environment.NewLine);
        }

        public static void Log(Exception ex)
        {
            Log(ex.Message);
        }
    }
}
