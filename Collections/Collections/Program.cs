using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList ar = MyCollections.NewCollection(7);
            MyCollections.Print(ref ar);
            Console.WriteLine("\nCapacity = " + ar.Capacity);

            Console.WriteLine();
            MyCollections.DelElement(2,1,ref ar);
            MyCollections.Print(ref ar);
            Console.WriteLine("\nCapacity = " + ar.Capacity);

            MyCollections.AddElement(2, ref ar);
            MyCollections.AddElement(2, ref ar);
            MyCollections.AddElement(2, ref ar);
            MyCollections.AddElement(2, ref ar);
            MyCollections.Print(ref ar);
            Console.WriteLine("\nCapacity = " + ar.Capacity);

            Console.WriteLine();

            ar.Sort();
            MyCollections.Print(ref ar);
            Console.WriteLine();
                  
        }
    }

    class MyCollections
    {
        public static ArrayList NewCollection(int n)
        {
            Random r = new Random();
            ArrayList ar = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                ar.Add(r.Next(10));
            }

            return ar;
        }

        public static void DelElement(int start, int end, ref ArrayList ar)
        {
            ar.RemoveRange(start, end-start+1);
        }

        public static void AddElement(int index, ref ArrayList ar)
        {
            //ar.Add(new Random().Next(10));
            ar.Insert(index, new Random().Next(10));
        }

        //public override string ToString()
        //{
        //    foreach(var item in )
        //}
        public static void Print(ref ArrayList ar)
        {
            foreach (var item in ar)
                Console.Write(" "+item);
        }
    }
}
