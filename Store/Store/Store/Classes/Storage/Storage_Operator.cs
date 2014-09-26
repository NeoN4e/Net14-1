using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    partial class Storage
    {
        Goods this[int index]
        {
            get { return this.storage[index]; }
        }

        //( get{return this.Storage[index]};)
    }
}
