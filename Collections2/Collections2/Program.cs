using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class People
    {
        //public int field;
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return ""+this.Name+" "+this.Age;
        }

        //public int operator +(int a, int people)
        //{ return 1; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //List<int?> digits = new List<int?> {1-1,1,2,3,4,5,null};

            //List<People> LP = new List<People> 
            //{ 
            //    new People() { Name = "Ivanov", Age = 55 }, 
            //    null,
            //    null,
            //    new People() { Name = "Petrov", Age = 20 } 
            //};

            //LP.Add(new People() { Name="Test",Age=2});
            ////LP.RemoveAt(1);
            
            //LP.Remove(null);
            ////LP.RemoveAll(null);
            
            //foreach (var item in LP)
            //{
            //    if (item != null)
            //    {
            //        Console.WriteLine(item.Name + " " + item.Age);
            //    }
            //    else
            //    {
            //        Console.WriteLine("NULL");
            //    }

            //}

            //Hashtable Table = new Hashtable(10, 0.5f);
            //Table.Add("1", "10");
            //Table.Add("2", "20");
            //Table.Add("3", "30");
            //Table.Add("4", "40");
            //Table.Add("5", "10");

            //ICollection iColl = Table.Keys;
            //foreach (var key in iColl)
            //{
            //    Console.WriteLine(key + " => " + Table[key]);
            //}

            //Stack<string> st = new Stack<string>(10);

            //Stack st1 = new Stack();
            //st1.Push("a");
            //st1.Push("b");
            //st1.Push("c");
            //st1.Push("d");

            //foreach (var item in st1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(st1.Count);
            //Console.WriteLine();
            //Console.WriteLine("peek="+st1.Peek());
            
            //Console.WriteLine();

            //while(st1.Count > 0)
            //{
            //    Console.WriteLine(st1.Pop());
            //}

            //Console.WriteLine(st1.Count);

            //Queue<int?> Q = new Queue<int?>();
            //Q.Enqueue(1);
            //Q.Enqueue(2);
            //Q.Enqueue(null);
            //Q.Enqueue(3);
            
            //// Console.WriteLine("Peek="+Q.Peek());
            //Console.WriteLine("Dequeue1=" + Q.Dequeue());
            //Console.WriteLine("Dequeue2=" + Q.Dequeue());
            //Console.WriteLine("Count=" + Q.Count);
            //foreach (var item in Q)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<int, People> D = new Dictionary<int, People>();
            //D.Add(1, new People() { Name="Ivanov", Age=10});
            //Console.WriteLine(D[1]);

            //LinkedList<int> LL = new LinkedList<int>();
            //LL.AddFirst(1);
            //LL.AddLast(2);
            //LL.AddLast(3);
            //LL.AddLast(4);
           
            //foreach(var item in LL)
            //    Console.WriteLine(item);

            //Console.WriteLine();
            //Console.WriteLine("First");
            //LinkedListNode<int> LN;
            
            //for (LN = LL.First; LN != null; LN = LN.Next)
            //{
            //    Console.WriteLine(LN.Value);
            //}

            //Console.WriteLine();
            //Console.WriteLine("Last");
            //for (LN = LL.Last; LN != null; LN = LN.Previous)
            //{
            //    Console.WriteLine(LN.Value);
            //}

            //SortedList<int?, People> Sl = new SortedList<int?, People>(10);
            //Sl.Add(2, new People() { Name = "Ivanov", Age = 10 });
            //Sl.Add(1, new People() { Name = "Petrov", Age = 11 });
            //Sl.Add(3, new People() { Name = "Sidorov", Age = 12 });
            //Sl.Add(4,null);

            //Console.WriteLine(Sl.Capacity);
            //Sl.TrimExcess();
            //Console.WriteLine(Sl.Capacity);

            //foreach (var item in Sl)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(DateTime.Now());
            
        }

        interface iTest<T> 
        {
            public T operator +(T a, T b);
            //{}
        }

        //void test<T>(T a, T b)
        //{
        ////    a + b;
        //}
    }

    
}