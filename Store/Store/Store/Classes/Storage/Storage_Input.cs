using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Store
{
    partial class Storage
    {
        /// <summary>
        /// Добавить товар на склад
        /// </summary>
        /// <param name="t">Объект класса товар</param>
       public void input(Goods t)
       {
           if (this.storage.Contains(t))
           {
               int index = this.storage.IndexOf(t);
               Goods g = this.storage[index];
               g.Quantity += t.Quantity;
               this.storage[index] = g;
           }
           else
           { this.storage.Add(t); }
       }
     
    }
}
