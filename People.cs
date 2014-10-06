using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class People
    {
        public string FIO { get; set; }
        public int Age { get; set; }

        public People()
        { }

        public People(string fio, int age)
        {
            this.FIO = fio;
            this.Age = age;
        }

        public override string ToString()
        {
            return String.Format("Имя:{0} Возраст:{1}");
        }
    }
}
