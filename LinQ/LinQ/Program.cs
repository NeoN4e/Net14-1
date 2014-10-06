using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Product
    {
        public double Prise { get; set; }
        public string Name { get; set; }

        //public override string ToString()
        //{
        //    return String.Format("{0} - {1}",this.Name,this.Prise);
        //}
    }

    static class ExtClass
    {
        //public static void Clear(this List<Product> lp,int b)
        //{
        //    double rezalt =0d;

        //    foreach (var item in lp)
        //        rezalt += item.Prise;

        //    Console.WriteLine(rezalt);
        //    //return rezalt;
        //}
        static public override string ToString(this Product lp)
        {
            return String.Format("{0} - {1}", lp.Name, lp.Prise);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> Bag = new List<Product>() 
            { 
                new Product(){Name = "Банан", Prise = 10},
                new Product(){Name = "Кокос", Prise = 15},
                new Product(){Name = "Ананас", Prise= 5}
            };

            
            foreach(var item in Bag)
                Console.WriteLine(item);

            //Console.WriteLine(Bag.GetAllPrice(3));

            //Console.WriteLine(Bag.Clear());
            //Bag.Clear(1);
           // Console.WriteLine(Bag.Count);
        }
    }
}