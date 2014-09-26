using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tovar
{
    class Tovar
    {
        public string Name { get; set; }
        public string Vendor { get; set; }
        public string Description { get; set; }

        double price;
        public double Price 
        { 
            get
            {
               return price;
            } 
          
            set
            {
                if(value < 0) throw new ArgumentOutOfRangeException("Цена не может быть отрицательной");
                this.price=value;
            } 
        }

        //Конструктор
        public Tovar(string name, string vendor, double price, string description = "")
        {
            this.Name = name;
            this.Vendor = vendor;
            this.Price = price;
            this.Description = description;
            
        }

        public override string ToString()
        {
            return String.Format("Наименование:\t{0} \nЦена:\t{1:0.00}", this.Name, this.Price);
        }

        
    }
}
