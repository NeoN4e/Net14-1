using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    partial class Storage
    {
        protected List<Goods> storage;

        public Storage()
        {
            storage = new List<Goods>();
        }

        public int StorageLength()                         // кол-во товаров на складе
        {
            return storage.Count;
        }
        public bool SearchName(string name)                // поиск по имени
        {
            for (int i = 0; i < StorageLength(); i++)
                if (this.storage[i].Name == name)
                    return true;
            return false;
        }

    }
}
