using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test21
{
    public interface Ilibrary
    {
        IQueryable<Category> Categories { get; }
    }
}
