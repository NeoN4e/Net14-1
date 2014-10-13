using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWPF
{
    public interface Person
    {
        string Name { get; set; }
    }

    public class Manager : Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Employee : Person
    {
        public string Name { get; set; }
        public string ManagerName { get; set; }
    }
}
