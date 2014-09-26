using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Emploe E= new Emploe();
            
            Console.WriteLine(E);
            ((IWorking)E).Work(); 
            Console.WriteLine(E);

               //Dictionary<string,string>
        
        }

    interface IWorking
    {
        bool isWorking { get; set; }

        object Work();
    }

    interface IWorkingTest
    {
        bool isWorking { get; set; }

        object Work();
    }

    class Emploe : IWorking, IWorkingTest
    {
        string FIO { get; set; }
        string Post { get; set; }

        public bool isWorking { get; set; }

        public Emploe()
        {
            this.FIO = "Иванов Иван Иванович";
            this.Post ="грузчик";
            this.isWorking = false;
        }

        object IWorking.Work()
        {
            if (this.isWorking == true) this.isWorking = false;
            else this.isWorking = true;

            return this.isWorking; 
        }

        object IWorkingTest.Work()
        { return 0; } 

        public override string ToString()
        {
            return "" + Post +" "+ this.FIO + " " + ((this.isWorking == true) ? "Работает" : "Спит");
        }

    }
}
