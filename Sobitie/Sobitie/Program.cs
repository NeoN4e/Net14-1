using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobitie
{
  //  delegate void Change();
    //interface ITest
    //{
    //    delegate void G();
    //}
    class MyEventArg : EventArgs
    {
        public string item{get;set;}
        
        public MyEventArg(string i)
        { this.item = i; }
    }
    class People
    {
    
        string fname;
        string lname;
        
        public string LName
        {
            get{ return this.lname; }
            set
            {
                this.lname = value;
                if (change != null) 
                {
                    change(this, new MyEventArg("lname"));
                }
            }
        }

        public string FName
        {
            get { return this.fname; }
            set
            {
                this.fname = value;
                if (change != null)
                {
                    change(this,new MyEventArg("fname"));
                }
            }
        }
        
        public People(string name)
        { this.LName = name; }

        public override string ToString()
        { return "FName: "+this.FName+" "; }

        //public event Change change;
        public event EventHandler change;
        //{ 
        //    add { Console.WriteLine(value); }
        //    remove { Console.WriteLine(value); }
        //}

        //public delegate void Change(Object o, EventArgs e);
        //public Change change=null;
        
    }

    class Program
    {
        static void ChangeName(Object obj, EventArgs earg)
        {
            
            Console.WriteLine("Обработчик 1" + obj+" "+(earg as MyEventArg).item);
        }

        //static void ChangeName2(Object obj, EventArgs earg)
        //{
        //    Console.WriteLine("Обработчик 2" + obj + " " + earg.item);
        //}

        static void Main(string[] args)
        {
            People p = new People("Вася");
            Console.WriteLine(p);

            p.change += ChangeName;
            //p.change += ChangeName2;
            //p.change -= ChangeName2;

            p.FName = "Петя";
            p.LName = "Петров";

            Console.WriteLine(p);

            //p.change = null;
            //p.Name = "П";
            //Console.WriteLine(p);

        }


    }
}
