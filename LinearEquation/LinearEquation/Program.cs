using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinearEquation L1 = new LinearEquation(1, 2, 3);
            LinearEquation l1, l2, l3;
            l1 = LinearEquation.parse("2 -1 -1"); 
            Console.WriteLine(l1);
            Console.Write(" X = 0 , Y ={0}",l1.GetRezaltY());
            Console.Write("\t\t or X = {0} , Y = 0", l1.GetRezaltX());

            Console.WriteLine("\n");
            l2 = LinearEquation.parse("3 -2 0");
            Console.WriteLine(l2);
            Console.Write(" X = 0 , Y ={0}", l2.GetRezaltY());
            Console.Write("\t\t or X = {0} , Y = 0", l2.GetRezaltX());

            Console.Write("\n\n");
            Console.WriteLine("Система Линейных уравнений");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("\n"+LinearEquation.GetSystemRezalt(l1, l2));
            Console.ResetColor();

            l3 = LinearEquation.parse("1 0 1");
            Console.WriteLine(l3);
            Console.WriteLine(l3.GetRezaltY());

        }
    }

    class LinearEquation
    {
        //ax+by+c=0;
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        //public double X { get; }
        //public double Y { get; }

        public LinearEquation(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public LinearEquation(double a, double c = 0)
        {
            this.A = a;
            this.B = 0;
            this.C = c;
        }

        public double GetRezaltX(double y=0)
        {
            return (-C - B*y ) / (double)A;
        }

        public double GetRezaltY(double x = 0)
        {
            return (-C - A * x) / (double)B;
        }

        static public string GetSystemRezalt(LinearEquation l1, LinearEquation l2)
        {
            double X = new LinearEquation(l1.A - l1.B * l2.A / l2.B, l1.C - l2.C * l1.B / l2.B).GetRezaltX();
            double Y = l1.GetRezaltY(X);

            return String.Format("X = {0} , Y = {1}", X, Y);
        }

        static public LinearEquation parse(string str)
        {
            string[] MyArr;
            MyArr=str.Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);

            //if (MyArr.Length > 3 || MyArr.Length == 0) throw new FormatException("Не верное количенство параметров");
            switch (MyArr.Length)
            {
                case 1: return new LinearEquation(Convert.ToInt32(MyArr[0]) );
                case 2: return new LinearEquation(Convert.ToInt32(MyArr[0]), Convert.ToInt32(MyArr[1]) );
                case 3: return new LinearEquation(Convert.ToInt32(MyArr[0]), Convert.ToInt32(MyArr[1]), Convert.ToInt32(MyArr[2]) );
                //default: throw new FormatException("Не верное количенство параметров"); break;
            }

            throw new FormatException("Не верное количенство параметров");
         }


        public override string ToString()
        {
            string str = "";
            if (A != 0) str += A + "X";
           
            if (B != 0) str += (str.Length > 0 ? " + " : "") +  B + "Y";
            
            if (C != 0) str += (str.Length > 0 ? " + " : "") +  C;

            str += " = 0";
            //str += "\n X = " + GetRezaltX() + "\t Y = 0";
            return str;
        }

    }
}
