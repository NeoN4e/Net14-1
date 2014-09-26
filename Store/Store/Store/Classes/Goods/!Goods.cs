using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    abstract partial class Goods
    {
        // Исключения закомментированы. Песле реализации Класса Исключений доделать.
        public int Quantity
        {
            get
            {
                return this.Quantity;
            }
            set
            {
                //if (value <= 0)
                //{
                //    throw MyException();
                //}
                //else
                this.Quantity = value;
            }
        }
        public double InputPrice
        {
            get
            {
                return this.InputPrice;
            }
            set
            {
                //if (value <= 0)
                //{
                //    throw MyException();
                //}
                //else
                this.InputPrice = value;
            }
        }
        public double OutputPrice
        {
            get
            {
                return this.OutputPrice;
            }
            set
            {
                //if (value <= 0)
                //{
                //    throw MyException();
                //}
                //else
                this.OutputPrice = value;
            }
        }
        public string Name
        {
            get
            {
                return this.Name;
            }
            set
            {
                //if (value.Length <= 0 || value.Length >= 15)
                //{
                //    throw MyException();
                //}
                //else
                this.Name = value;
            }
        }
        public string Description
        {
            get
            {
                return this.Description;
            }
            set
            {
                //if (value.Length <= 0 && value.Length >= 30)
                //{
                //    throw MyException();
                //}
                //else
                this.Description = value;
            }
        }

        /// <param name="name">Название</param>
        /// <param name="amount">Количество</param>
        /// <param name="iPrice">Цена закупки</param>
        /// <param name="oPrice">Цена продажи</param>
        /// <param name="description">Описание товара</param>
        public Goods(string name, int amount, double iPrice, double oPrice, string description)
        {
            Name = name;
            InputPrice = iPrice;
            OutputPrice = oPrice;
            Quantity = amount;
            Description = description;
        }
    }
}
