using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace test21
{
    [TableAttribute("")]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
