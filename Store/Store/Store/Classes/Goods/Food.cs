using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Food : Goods
    {
        public Food(string name  /*Название*/, int amount /*Количество*/, double iPrice /*Цена закупки*/,
            double oPrice/*Цена продажи*/, string description /*Описание товара*/)
            
        :base(name, amount, iPrice, oPrice, description)
        { }

        
        
    }
}
