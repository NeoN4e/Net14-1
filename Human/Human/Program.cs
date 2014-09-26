using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Object s = new Student("Иван  Иван Иванович", 10, "C#");
            Console.WriteLine(s);
        }
    }

    class Human
    {
        string fio;
        int age;
        
        public Human(string fio, int age)
        {
            this.fio = fio;
            this.age = age;
        }

        public override string ToString()
        {
            return string.Format("ФИО:{0}\nВозраст:{1}",fio,age);
        }

        //public virtual void print()
        //{ Console.WriteLine("1"); }
    }

    class Student : Human
    {
        string nameGroup;

        public Student(string fio, int age, string gr)
            : base(fio, age)
        { nameGroup = gr; }

        public override string ToString()
        {
            return base.ToString() + "\nГруппа:" + nameGroup;
        }

 
    }
     

}
