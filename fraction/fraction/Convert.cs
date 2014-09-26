using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fraction
{
    public partial class fraction
    {
        public static implicit operator fraction (int a)
        { return new fraction(a,1);}

        public static implicit operator fraction(double d)
        { return new fraction(d); }

		public static explicit operator double(fraction f)
		{ return f.Numerator / f.Denominator;}
    }
}
