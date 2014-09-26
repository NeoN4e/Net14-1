using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fraction
{
    public partial class fraction
    {
        //>
        static public bool operator >(fraction a, fraction b)
        { return a.Numerator * b.Denominator > b.Numerator * a.Denominator; }

        //<
        static public bool operator <(fraction a, fraction b)
        { return a.Numerator * b.Denominator < b.Numerator * a.Denominator; }

        //==
        static public bool operator ==(fraction a, fraction b)
        { return a.Numerator * b.Denominator == b.Numerator * a.Denominator; }

        //!=
        static public bool operator !=(fraction a, fraction b)
        { return a.Numerator * b.Denominator != b.Numerator * a.Denominator; }

        static public bool operator true(fraction a)
        { return a.Numerator < a.Denominator; }

        static public bool operator false(fraction a)
        { return a.Numerator > a.Denominator; }
    }
}
