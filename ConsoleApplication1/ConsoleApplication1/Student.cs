using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Group { get; set; }
        public int Age { get; set; }
        int[][] grades = new int[3][];
        public int[][] Grades 
        { 
            get
            {
                return grades;
            }
        }

        static int countStudent=0;
        static public int CountStudent 
        {
            get { return countStudent; }
        }

        public Student(Random r)
        {
            
            countStudent++;
            this.FirstName = "Имя " + countStudent;
            this.LastName = "Фамилия " + countStudent;
            this.Group = "Группа " + countStudent;
            this.Age = r.Next(17, 50);
            for (int i = 0; i < grades.GetLength(0); i++)
            {
                grades[i] = new int[r.Next(1, 7)];
                for (int j = 0; j < grades[i].Length; j++)
                {
                    grades[i][j] = r.Next(1, 12);
                }
            }
        }

        static public void StudentPrint(List<Student> st)
        {
            foreach (var s in st)
            {
                Console.Write("Ф.И.:{0} {1}\nГруппа:{2}\nВозраст:{3}\nОценки:",s.LastName,s.FirstName,s.Group,s.Age);
                foreach (var elem in s.Grades)
                {
                    foreach (var e in elem)
                    {
                        Console.Write(e + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}
