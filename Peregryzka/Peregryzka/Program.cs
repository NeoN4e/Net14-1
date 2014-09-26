using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peregryzka
{
    class Program
    {
        static void Main(string[] args)
        {

            Humman H = new Humman();
            H.Print();

            H.LName = "Василий";
            H.EyeColor = ConsoleColor.DarkYellow;
            H.Print();
            
            Console.WriteLine(H.FIO);
            //int[] myArr = { 1,2,3,4,5,6,7,8,9,0};
            //Console.WriteLine(Summ(myArr));

            //int a = 7, b=8, c=3;
            //Console.WriteLine(Summ(a,b));
            //Console.WriteLine(Summ(a, b,c));

            
        }


        //static public int Summ(int a, int b, int c = 0)
        //{
        //    return a + b + c;
        //}

        //static public int Summ(int a, int b)
        //{
        //  //  Console.WriteLine("*");
        //    return a + b;

        //}

        //static public int Summ(int[] Arr)
        //{
        //    int summ=0;
        //    foreach(int item in Arr)
        //    {
        //        summ+=item;
        //    }
        //    return summ;
        //}
    }

    class Humman
    {
        string fName = "Иванов";
        string lName = "Иван";
        int age=25;
        bool sex=true;
        ConsoleColor eyeColor = ConsoleColor.Green;
        //Свойства
        public string LName
        {
            get { return lName;}
            set { lName = value;}
        }
        public ConsoleColor EyeColor
        {
            set { eyeColor = value; }
        }

        public string FIO
        {
            get { return fName + " " + LName; }
        }

        //методы
        public void Print()
        {
            Console.ForegroundColor = eyeColor;
            Console.WriteLine("\nФамилия:\t{0}\nИмя:\t\t{1}\nВозраст:\t{2}", fName, lName, age);
            //string str=(sex==true)?"мужской":"женский";
            Console.WriteLine("Пол:\t\t{0}", (sex == true) ? "мужской" : "женский");
            Console.ResetColor();
        }
    }
}
