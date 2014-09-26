using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyDoctor
{
    class Patient
    {
        ///<summary>Фамилия пациента</summary>
        public string FIO { get; set; }

        ///<summary>Список состояния больного</summary>
        Dictionary<string, bool> Status = new Dictionary<string, bool>();

        ///<summary>Конструктор</summary>
        public Patient()
        {
            this.Status.Add("Температура", BoolRandom.GenRandStatus());
            this.Status.Add("Живот", BoolRandom.GenRandStatus());
            this.Status.Add("Перелом", BoolRandom.GenRandStatus());
        }

        ///<summary>Индексатор по ключу возвращает состояние дольного</summary>
        public bool this[string key]
        {
            get { return this.Status[key]; }
            set { this.Status[key] = value; }
        }

        /// <summary>У пациента сделайте метод типа стало хуже и пусть когда станет хуже, то он идет к доктор</summary>
        /// <returns>True если есть проблеммы со здоровьем</returns>
        public bool isBed()
        {
            foreach (var item in this.Status)
                if (item.Value == false) return true;

            return false;
        }
        
        ///<summary>Нумератор для foreache, перебирает все болячки</summary>
        public Dictionary<string, bool>.Enumerator GetEnumerator()
        {
            return this.Status.GetEnumerator();
        }

        /// <summary>Выводит в окно консоли все статусы здоровья</summary>
        public void PrintStatus()
        {
            Console.WriteLine("{0}:",this.FIO);
            foreach (var item in this.Status)
            {
                
                Console.Write("[{0,15} ",item.Key);

                if (item.Value) ConsolePrint.ColorWrite("True ",ConsoleColor.DarkGreen);
                else ConsolePrint.ColorWrite("False", ConsoleColor.Red);

                Console.Write("] \n", item.Key);
                
            }
        }


        ///<summary>Текстове представление Объекта</summary>
        public override string ToString()
        {
            return this.FIO;
        }

    }

}
