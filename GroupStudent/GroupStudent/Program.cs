using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация и начальное заполнение группы
            Group g1 = new Group("Net14-1") 
            { 
                new Student("Иванов","Иван",50)
                ,new Student("Петовр","Петр",20)
                ,new Student("Сидоров","Сидр:)",21)
                ,new Student("Антонов","Антон:)",21)
            };

            //разные варианты сортировки
            //g1.sort(new StudentSort.SortByAge());
            //g1.sort(new StudentSort.SortByFirstName());
            g1.sort(new StudentSort.SortByAvgRaiting());

            //Вывод на Экран ФИО Студентов
            foreach (Student s in g1)
            {
                Console.WriteLine("{0} средний бал ={1:.##}",s,s.GetAvgRaiting());
                             
                //Вывод всех оценок
                foreach(var item in s)
                    Console.WriteLine(item+"\t");

                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }

    class Student: System.Collections.IEnumerable , IComparable
    {
        ///<summary> Имя студента </summary>
        public string Name { get; private set; }

        ///<summary>Фамилия студента</summary>summaru>
        public string Firstname { get; private set; }

        public int Age { get; private set; }

        /// <summary> Статический массив наименований предметов</summary>
        private static string[] predmetName = { "C#", ".Net", "Java", "C++" }; 

        /// <summary> Массив оценок </summary>
        int[][] journal;
        
        //Статический рандом для генерации разных оценок
        static Random r = new Random(); 

        /// <summary> Конструктор </summary>
        public Student(string fname, string name, int age)
        {
            this.Firstname = fname;
            this.Name = name;

            if (age < 0) this.Age = 0;
            else this.Age = age;

            //заполнение массива оценок
            journal=new int[predmetName.Length][];
            for (int i = 0; i < journal.Length; i++)
            {
                journal[i]=new int[r.Next(1,10)];
                
                for (int j = 0; j < journal[i].Length; j++)
                    journal[i][j] = r.Next(5, 12);
            }
        }

        /// <summary> Средняя Оценка по всем предметам</summary>
        public double GetAvgRaiting()
        {
            double sum = 0d; //сумма всех оценок
            int qty = 0; // количество оценок
            //переберем массив оценок по предметно
            for (int i = 0; i < journal.Length; i++)
            {
                for (int j = 0; j < journal[i].Length; j++)
                { sum += journal[i][j]; qty++;}
            }

            return sum / qty; 
        }

        //Реализация IEnumerable
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            //return this.journal.GetEnumerator();

            string predmetRaiting;

            //переберем массив оценок по предметно
            for(int i=0; i<journal.Length;i++)
            {
                predmetRaiting = String.Format("{0,5}:",predmetName[i]);
                for(int j=0; j < journal[i].Length; j++)
                {
                    predmetRaiting += " " + journal[i][j];
                }

                yield return predmetRaiting;
            }
             
        }

        //Метод сравнения(по возрасту) интерфейса IComparable
        public int CompareTo(object obj)
        {
            if (this.Age > ((Student)obj).Age) return 1;
            if (this.Age < ((Student)obj).Age) return -1;

            return 0;
        }

        public override string ToString()
        { return this.Firstname+" "+this.Name+"("+this.Age+")";}

  
    }

    class Group:System.Collections.IEnumerable
    {
        /// <summary> Имя группы</summary>
        public string Groupname { get; private set; }

        /// <summary> Список студентов группы </summary>
        List<Student> Students;

        /// <summary> Конструктор</summary>
        public Group(string name)
        { 
            this.Groupname = name; 
            this.Students = new List<Student>();
        }
        
        /// <summary>
        /// метод добавлнеия студента
        /// </summary>
        /// <param name="s"> объект типа студент </param>
        public void Add(Student s)
        {
            this.Students.Add(s);
        }

        //Реализация интерфейса IEnumerable
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.Students.GetEnumerator();
        }

        //Сортировка студентов в списке по Возрасту
        //public void SortByAge()
        //{ this.Students.Sort(); }

        public void sort(IComparer<Student> Comparer)
        { this.Students.Sort(Comparer); }
    }

    class StudentSort
    {
        public class SortByAge : IComparer<Student>
        {
            public int Compare(Student obj1, Student obj2)
            {
                int Age1 = (obj1 as Student).Age;
                int Age2 = (obj2 as Student).Age;

                return Age1.CompareTo(Age2);
            }

        }

        public class SortByFirstName : IComparer<Student>
        {
            public int Compare(Student obj1, Student obj2)
            {
                String Fname1 = (obj1 as Student).Firstname;
                String Fname2 = (obj2 as Student).Firstname;

                return String.Compare(Fname1,Fname2);
            }
        }

        public class SortByAvgRaiting : IComparer<Student>
        {
            public int Compare(Student obj1, Student obj2)
            {
                String Fname1 = (obj1 as Student).Firstname;
                String Fname2 = (obj2 as Student).Firstname;

                return String.Compare(Fname1, Fname2);
            }
        }
    }
}
