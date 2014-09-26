using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueFifo<int> myQueue = new QueueFifo<int>()
            { 10, 20, 30, 40 };

            //myQueue.GetEnumerator();

            ////QueueCircle<int> myQueue = new QueueCircle<int>();
            /*    myQueue.Add(10);
                myQueue.Add(20);
                myQueue.Add(10);
                myQueue.Add(30);
            ////{ 10, 20, 30, 40 };
            */
            //QueuePriorityEx<string> myQueue = new QueuePriorityEx<string>();
            //QueuePriorityIn<string> myQueue = new QueuePriorityIn<string>();
            //myQueue.Add("Ivanov");
            //myQueue.Add("Petrov",4);
            //myQueue.Add("Sidorov",5);
            //myQueue.Add("Vasya",4);
            //myQueue.Add("Petya",1);
            

            myQueue.Print();
            Console.WriteLine("Peek={0}",myQueue.Peek);

            Console.WriteLine();
            Console.WriteLine("remove {0}", myQueue.Remove());
            Console.WriteLine("remove {0}", myQueue.Remove());
            Console.WriteLine("remove {0}", myQueue.Remove());
           // Console.WriteLine("remove {0}", myQueue.Remove());
           // Console.WriteLine("remove {0}", myQueue.Remove());

            Console.WriteLine();
            Console.WriteLine("Foreach");
            //myQueue.Print();
            foreach (var item in myQueue)
            { Console.WriteLine(item); }
            Console.WriteLine("Peek={0}", myQueue.Peek);
        }
        
    }

    class QueueFifo<T> :IEnumerable<T>,IEnumerator<T> //: ICollection<T>
    {
        protected List<T> list = new List<T>();
        
        public int Count { get { return this.list.Count; } }

        public void Add(T obj)
        { this.list.Add(obj); }

        public T Remove()
        {
            T temp = this.Peek;
            this.list.Remove(temp);
            return temp;
        }

        public void Print()
        {
            foreach (var item in this.list) Console.WriteLine(item);
        }

        public virtual T Peek
        { get { return this.list[0]; }}

        //public System.Collections.IEnumerator GetEnumerator()
        //{ return this.list.GetEnumerator(); }

       // public IEnumerator<T> GetEnumerator()
       // { return this.list.GetEnumerator(); }

        public IEnumerator<T> GetEnumerator()
        {
           // throw new NotImplementedException();
            
            //return this.list.GetEnumerator();
            return (IEnumerator<T>)this;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// IEnumerator
        /// </summary>
        private int CurentId { get; set; }

        public T Current
        {
           // get { throw new NotImplementedException(); }
            get{ return this.list[this.CurentId];}           
        }

        public void Dispose()
        {
            // throw new NotImplementedException();
            //Console.WriteLine("OK");
        }

        object System.Collections.IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
            //get { return this.list[this.CurentId]; }    
        }

        public bool MoveNext()
        {
            //throw new NotImplementedException();
            if (this.list.Count <= this.CurentId + 1) { this.CurentId++; return true; }
            else return false;
        }

        public void Reset()
        {
            //throw new NotImplementedException();
            this.CurentId = 0;
        }
    }

    /// <summary>
    /// Круговая очередь
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class QueueCircle<T> : QueueFifo<T>
    {
        public new T Remove()
        {
            T temp = base.Remove();
            this.Add(temp);
            return temp;
        } 
    }

    /// <summary>
    /// Элемент очереди с приоритетом
    /// </summary>
    /// <typeparam name="T"></typeparam>
    struct QueueItem<T> : IComparable<QueueItem<T>>
    {
        public int Priority { get; set; }
        public T Value { get; set; }

        public override string ToString()
        {
            return String.Format("[{0}  =  {1}]",this.Priority,this.Value);
        }

        public int CompareTo(QueueItem<T> obj)
        {
            if (obj.Priority>this.Priority) return -1;
            if (obj.Priority<this.Priority) return 1;
            
            return 0;
        }
    }

    /// <summary>
    /// Очередь с приоритетов исключения
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class QueuePriorityEx<T> : QueueFifo<QueueItem<T>>
    {
        //private new void Add(T obj) { }

        public void Add(T obj, int priority = 10)
        { base.Add(new QueueItem<T> { Value = obj, Priority = priority }); }

        public override QueueItem<T> Peek
        //{ get{return new QueueItem<T>();} }
       { get{return this.list.Min();} }

    }

    /// <summary>
    /// Очередь с приритетом включения
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class QueuePriorityIn<T> : QueueFifo<QueueItem<T>>
    {
        public void Add(T obj, int priority = 10)
        { 
            base.Add(new QueueItem<T> { Value = obj, Priority = priority });
            this.list.Sort();
        }

        
    }


}
