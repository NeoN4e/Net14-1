using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
           Random R=new Random();
           Student S=new Student("Иванов","Иван",25);
           S.AddRating(0,10);
           S.AddRating(0,5);

           //Console.WriteLine(S.GetRating(0));

           Student[] Net14_1 = new Student[15];

           for (int i = 0; i < Net14_1.Length; i++)
           {
               try
               {
                   Net14_1[i] = new Student("Студент" + i, "Имя" + i, R.Next(20, 40), "Net14-1");
                   for (int j = 0; j < 5; j++) //Кво предметов
                   {
                       for (int qty = 1; qty < R.Next(10); qty++) //Кво Оценок
                       { Net14_1[i].AddRating(j, R.Next(1, 12)); }

                   }
               }
               catch { }
               
           }


               foreach (var student in Net14_1)
               {
                   Console.WriteLine(student + student.GetALLRating());
                   Console.WriteLine();
               }

               Console.ForegroundColor = ConsoleColor.DarkYellow;
               Console.WriteLine(Student.GetAllGroupQty());
            
        }
    }

    class Student
    {
        int[][] rating;
       
        static string[] predmetName = {"C#",".Net","Java","C++"};
        static string[] groupName = new string[0];
        static int[] groupStydentQty = new int[0];

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        string group;
        public string Group 
        { 
            get{return group;}
            set
            {
                int groupId = GroupAdd(value);
                groupStydentQty[groupId] += 1;

                group = value;
            } 
        }

        static public int GetStudentQty(int groupId)
        { return groupStydentQty[groupId]; }

        static public int GetStudentQty(string gName)
        {
            int groupId;
            groupId = Array.IndexOf(groupName, gName);
            if (groupId == -1) return -1;//Группа не найденна

            return groupStydentQty[groupId]; 
        }

        static public string GetAllGroupQty()
        {
            string rezalt="";

            for (int i = 0; i < groupName.Length; i++ )
            {
                rezalt += GetGroupName(i) + "\t:\t" + GetStudentQty(i) + "\n";
            }
            return rezalt;
        }

        static public string GetGroupName(int groupId)
        { return groupName[groupId];}

        public int GroupAdd(string gName)
        {
            int groupID=Array.IndexOf(groupName,gName);
            if (groupID == -1) 
            {
                Array.Resize(ref  groupName,  groupName.Length + 1);
                groupID=groupName.Length - 1;
                groupName[groupID] = gName;

                Array.Resize(ref  groupStydentQty, groupID + 1);
                groupStydentQty[groupID] = 0;
            }

            return groupID; 
        }

        public Student(string FirstName, string LastName, int Age, string Group = "C#")
        {
        
            if (GetStudentQty(Group) >= 12)
            {
                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine("Группа" + Group + "переполнена");
                //Console.ResetColor();
               // this("none");

                // Создаем локальную переменную для получения
                // свойства HelpLink
                Exception exc = new Exception();
                //exc.HelpLink = "http://www.professorweb.ru";
                // Вставка специальных дополнительных данных
                // имеющих отношение к ошибке
                exc.Data.Add("Время возникновения: ", DateTime.Now);
                exc.Data.Add("Причина: ", "Группа" + Group + "переполнена");
                throw exc;

                return ;
            } 

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Group = Group;

            //this.rating = new int[5][];
            
            //stydentQty++;
        }

        public string GetRating(int id)
        {
            string rezalt = ""+predmetName[id]+"\t:\t";
            if (rating[id] != null)
            {

                foreach (int item in rating[id])
                { rezalt += item + " "; }
            }

            return rezalt;
        }

        public string GetALLRating()
        {
            string rezalt = "";
            for(int i = 0 ; i < rating.Length; i++)
            { rezalt += "\n\t" + GetRating(i); }
            
            return rezalt;
        }

        public void AddRating(int id, int item)
        {
            if (id > predmetName.Length - 1) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нет предмета с Индексом "+id);
                Console.ResetColor();
                return; 
            }

            if (rating == null) rating = new int[predmetName.Length][];
            if (rating[id] == null) rating[id] = new int[1];
            else Array.Resize(ref rating[id], rating[id].Length + 1);

            rating[id][rating[id].Length - 1] = item;
        }

        public override string ToString()
        {
            return "" + FirstName + " " + LastName + " (" + Group + ")"; 
        }
    }

    
}
