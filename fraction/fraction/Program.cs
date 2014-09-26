using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fraction
{
    class Program
    {
        static fraction ReadFractionFromConsole()
        {
            fraction f;

            do
            {
                try
                {
                    Console.WriteLine("Введите дробь");
                    f = new fraction(Console.ReadLine());
                    break;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            } while (true); 

           return f;
        }

        static void Main(string[] args)
        {
        //    fraction f=new fraction("1 16/2");
         
        //    Console.WriteLine(f.GetSimple());
        //    Console.WriteLine(f.GetMixet());

        //    Console.WriteLine(""+f.IntPart+" "+f.Numerator+" "+f.Denominator);
            //fraction f1,f2;
            //fraction rezalt;
            
            //Console.WriteLine(" Введите 2 дробных чвисла");

            //f1 = ReadFractionFromConsole();
            //f2 = ReadFractionFromConsole();

            //Console.Write("Вы ввели: ");
            //Console.Write("\n\t" + f1.GetMixet() + " (" + f1.GetSimple() + ")" + "\t\t\t" + f2.GetMixet() + " (" + f2.GetSimple() + ")\n");

            //Console.WriteLine("Сложение");
            //rezalt = f1+f2;
            //Console.WriteLine("" + f1.GetMixet() + " + " + f2.GetMixet() + " = " + rezalt.GetMixet());

            //Console.WriteLine("Вычитание");
            //rezalt = f1 - f2;
            //Console.WriteLine("" + f1.GetMixet() + " - " + f2.GetMixet() + " = " + rezalt.GetMixet());

            //Console.WriteLine("Умножение");
            //rezalt = f1 * f2;
            //Console.WriteLine("" + f1.GetMixet() + " * " + f2.GetMixet() + " = " + rezalt.GetMixet());

            //Console.WriteLine("Деление");
            //rezalt = f1 / f2;
            //Console.WriteLine("" + f1.GetMixet() + " / " + f2.GetMixet() + " = " + rezalt.GetMixet());

            //Console.WriteLine("Сложение с ИНТ");
            //rezalt = f1 + 10;
            //Console.WriteLine("" + f1.GetMixet() + " + " + 10 + " = " + rezalt.GetMixet());

            //rezalt = 20 + f2;
            //Console.WriteLine("" + 20 + " + " + f2.GetMixet() + " = " + rezalt.GetMixet());

            ////Console.WriteLine("-----");
            ////rezalt = ++f2;
            //Console.WriteLine("++ " + f2.GetMixet() + " = " + (++f2));
            //Console.WriteLine(new fraction(1.003));

            fraction f = new fraction(3, 4);
            int a = 10;
            fraction f1 = f * a;
            fraction f2 = a * f;
            double d = 1.5;
            fraction f3 = f + d;

            Console.WriteLine(f);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f3);

            //Console.WriteLine(f3<2);
            //Console.WriteLine(new fraction("100/9").());

            //fraction f = new fraction("10/2");
            //fraction f2 = new fraction("10/5");

            //fraction f3 = f * f2;
            //Console.WriteLine(f3);
            //Console.WriteLine(f3.GetSimple());
        }

    }

    public partial class fraction
    {
        //Поля
        private int numerator;   // Числитель
        private int denominator = 1; // Знаменатель

        //Сойства
            //public int IntPart //integral part of the fraction
            //{
            //    get { return numerator / denominator; }
            //}

            public int Numerator
            {
                get { return numerator; }
                protected set 
                {
                    numerator = value;
                }
            }

            public int Denominator
            {
                get {return denominator; }
                
                private set
                {
                    if (value == 0)
                    {
                        //Console.ForegroundColor = ConsoleColor.Red;
                        //Console.WriteLine("ЗНАМЕНАТЕЛЬ НЕ МОЖЕТ БЫТЬ 0");
                        //Console.ResetColor();

                        //numerator = 0;
                        //denominator = 1;

                        //ArgumentOutOfRangeException Exept = new new ArgumentOutOfRangeException();
                        //Exept.=0;
                        throw new ArgumentOutOfRangeException("Знаменатель", "ЗАМЕНАТЕЛЬ НЕ МОЖЕТ БЫТЬ 0");
                    }
                    else denominator = value;
                }
            }

            //Методы

            public string GetSimple()
            {
                if (Numerator == 0) return "0";
                else
                    return "" + numerator + "/" + denominator;
            }

            public string GetMixet()
            {
                //return "" + IntPart == 0 ? "" : IntPart + " " + Numerator + " / " + Denominator;
                if (Numerator == 0) return "0";
                if (Numerator / denominator == 0) return GetSimple();

                if (Numerator % Denominator == 0) return "" + Numerator / denominator;
                else return "" + Numerator / denominator + "  " + ((numerator < 0) ? -1 * numerator : numerator) % Denominator + "/" + Denominator;
            }

            private void Shrink()
            {
                //минус в знаменателе
                if (denominator < 0)
                {
                    denominator = -denominator;
                    numerator = -numerator;
                }

                int pointer = 1 ;
                int maxI = (numerator < 0) ? -1 * numerator : numerator;
                //if (denominator > numerator) return;
                for (int i = 1; i <= maxI; i++)
                {
                    pointer = maxI / i;
                    if (denominator % pointer == 0 && numerator % pointer == 0)
                    {
                        numerator /= pointer;
                        denominator /= pointer;
                        return;
                    }
                }
            }

        //Конструктор
        public fraction(int numerator, int denominator = 1)
        {
         //   if (denominator == 0) return;

            this.Numerator = numerator;
            this.Denominator = denominator;

            Shrink();
        }

        public fraction(int intPart ,int numerator, int denominator)
        {
          //  if (denominator == 0) return;

            this.Numerator = numerator + intPart * denominator;
            this.Denominator = denominator;

            Shrink();
        }

        public fraction(string str)
        {
            string[] elementArr = str.Split( new char[3]{' ','\t','/'},StringSplitOptions.RemoveEmptyEntries );
            
            
            switch(elementArr.Length)
            {
                case 1: Numerator = Convert.ToInt32(elementArr[0]); Denominator = 1; break;
                case 2: Numerator = Convert.ToInt32(elementArr[0]); Denominator = Convert.ToInt32(elementArr[1]); break;
                case 3:
                    Denominator = Convert.ToInt32(elementArr[2]); 

                    Numerator = Convert.ToInt32(elementArr[0]) * Denominator; // Целая часть
                    if (numerator < 0) numerator -= Convert.ToInt32(elementArr[1]); // Дробная часть
                    else numerator += Convert.ToInt32(elementArr[1]);

                    break;
                default: Denominator = 0; break; //ЭКСЕПШЕН
            }
            
            Shrink();
        }

        public fraction(double d)
        {
            //Определим кво знаков полсле точки
            //d.ToString().IndexOf('.');
            //return new fraction(d.ToString().Replace('.',' '));
            string str = d.ToString();
            string[] elementArr = str.Split(new char[2] {'.',','}, StringSplitOptions.RemoveEmptyEntries);

            Denominator = (int)Math.Pow(10.0 ,(double)elementArr[1].Length);
            Numerator = Convert.ToInt32(elementArr[0]) * Denominator + Convert.ToInt32(elementArr[1]);

            Shrink();
        }
        //Перегрузка Операторов

        //+
        static public fraction operator +(fraction a, fraction b)
        {
            if (a.Denominator == b.Denominator) return new fraction(a.Numerator + b.Numerator, a.Denominator);
            else
                return new fraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.denominator);    
        }

            //static public fraction operator +(fraction a, int b)
            //{
            //    return new fraction(a.Numerator + b * a.Denominator, a.Denominator );
            //}

            //static public fraction operator +(int b, fraction a)
            //{
            //    return new fraction(a.Numerator + b * a.Denominator, a.Denominator);
            //}

            //static public fraction operator +(fraction a, double d)
            //{
            //    return a + new fraction(d);
            //}
        //++
            static public fraction operator ++(fraction a)
            {
                return a+1;
            }

        //-
        static public fraction operator -(fraction a, fraction b)
        {
            if (a.Denominator == b.Denominator) return new fraction(a.Numerator - b.Numerator, a.Denominator);
            else
                return new fraction(a.Numerator * b.Denominator - b.Numerator * a.Denominator, a.Denominator * b.denominator);
        }

        //*
        static public fraction operator *(fraction a, fraction b)
        {
            return new fraction(a.Numerator * b.Numerator , a.Denominator * b.Denominator);
        }

            //static public fraction operator *(fraction a, int b)
            //{
            //    return new fraction(a.Numerator * b, a.Denominator);
            //}

            //static public fraction operator *(int b, fraction a)
            //{
            //    return a*b;
            //}

        static public fraction operator / (fraction a, fraction b)
        {
            return new fraction(a.Numerator * b.Denominator, b.Numerator * a.Denominator);
        }

        public override string ToString()
        {
            return GetMixet();
        }

        int this[int id]
        {
            get 
            {
                switch (id)
                {
                    case 1: return Numerator / Denominator;
                    case 2: return Numerator;
                    case 3: return Denominator;
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }

    }
}