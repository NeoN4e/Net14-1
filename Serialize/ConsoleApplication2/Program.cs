using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    [Serializable]
    class People
    {
        [NonSerialized]
        int age;
        string fio;
        static int count = 0;
        public string FIO { get { return fio; } set { fio = value; } }

        public int Age { get { return age; } set { age = value; } }
        public People()
        {
            People.count++;
            this.FIO = "fio"+People.count;
            //this.Age = ";
            
        }
        public People(string fio, int age)
        {
            this.FIO = fio;
            this.Age = age;
        }
        public override string ToString()
        {
            return string.Format("ФИО:{0}\nВозраст:{1}", this.FIO, this.Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //People p = new People("Иванов Иван Иванович", 23);
            ////MemoryStream fs = new MemoryStream();
            //FileStream fs = new FileStream("people.xml",FileMode.Create,FileAccess.ReadWrite);
            //SoapFormatter sf = new SoapFormatter();
            //sf.Serialize(fs, p);
            //fs.Seek(0, SeekOrigin.Begin);
            //People p1 = (People)sf.Deserialize(fs);
            //Console.WriteLine(p1);

            //List<People> list = new List<People>();
            //for (int i = 0; i < 5; i++)
            //{
            //    list.Add(new People());
            //}
            FileStream fs = new FileStream("peopleAll.xml", FileMode.Open, FileAccess.Read);
            SoapFormatter bf = new SoapFormatter();
          //  bf.Serialize(fs, list);
          //  fs.Seek(0, SeekOrigin.Begin);
            //foreach (People p in list)
            //{
            //    bf.Serialize(fs, p);
            //}
            //fs.Close();
            //fs.Seek(0, SeekOrigin.Begin);
            List<People> listTwo = new List<People>();
            for (int i = 0; i < 5; i++)
            {
                listTwo.Add((People)bf.Deserialize(fs));

            }
            foreach (People p in listTwo)
            {
                Console.WriteLine(p);
            }
        }
    }
}
