using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//using Ukrain;
using France;
using Egypt;

namespace Popylations
{
    class Program
    {
        static void Main(string[] args)
        {
            Ukrain.Kiev kiev= new Ukrain.Kiev();
            Console.WriteLine(""+kiev+" \t"+kiev.GetHashCode());
            
            Paris paris = new Paris();
            Console.WriteLine(""+paris+" \t"+paris.GetHashCode());

            Kair kair = new Kair();
            Console.WriteLine(""+kair+" \t"+kair.GetHashCode());



            Console.WriteLine(kair > paris);
            Console.WriteLine(kiev <= paris);
            Console.WriteLine(kiev != paris);
            Console.WriteLine(kiev == kiev);
        }
    }
}

namespace Ukrain
{
    class Kiev
    {
        int Popylations = 2869361;

        public override int GetHashCode()
        {
            return Popylations;
        }

        public override string ToString()
        { return "Kiev";}
    }

   
}

namespace France
{
    class Paris 
    {
        int Popylations =  2243833;
        
        public override string ToString()
        { return "Paris"; }
        
        public override int GetHashCode()
        {
            return Popylations;
        }

        // >
        public static bool operator >(Paris p,Kair k)
        { return p.GetHashCode() > k.GetHashCode(); }

            public static bool operator >(Kair k , Paris p )
            { return p>k; }

            //Kiev
            public static bool operator >(Paris p, Ukrain.Kiev k)
            { return p.GetHashCode() > k.GetHashCode(); }

            public static bool operator >(Ukrain.Kiev k, Paris p)
            { return p > k; }

        // <
        public static bool operator <(Paris p, Kair k)
        { return p.GetHashCode() < k.GetHashCode();}

            public static bool operator <(Kair k, Paris p)
            { return p < k; }

            //Kiev
            public static bool operator <(Paris p, Ukrain.Kiev k)
            { return p.GetHashCode() < k.GetHashCode(); }

            public static bool operator <(Ukrain.Kiev k, Paris p)
            { return p < k; }

        // ==
        public static bool operator ==(Paris p, Kair k)
            { return p.GetHashCode() == k.GetHashCode(); }

            public static bool operator ==(Kair k, Paris p )
            { return p.GetHashCode() == k.GetHashCode(); }

            //Kiev
            public static bool operator ==(Paris p, Ukrain.Kiev k)
            { return p.GetHashCode() == k.GetHashCode(); }

            public static bool operator ==(Ukrain.Kiev k, Paris p)
            { return p.GetHashCode() == k.GetHashCode(); }

       // !=
            public static bool operator !=(Paris p, Kair k)
            { return p.GetHashCode() != k.GetHashCode(); }

            public static bool operator !=(Kair k, Paris p)
            { return p.GetHashCode() != k.GetHashCode(); }

            //Kiev
            public static bool operator !=(Paris p, Ukrain.Kiev k)
            { return p.GetHashCode() != k.GetHashCode(); }

            public static bool operator !=(Ukrain.Kiev k, Paris p)
            { return p.GetHashCode() != k.GetHashCode(); }

       // >=
            public static bool operator >=(Paris p, Kair k)
            { return p.GetHashCode() >= k.GetHashCode(); }

            public static bool operator >=(Kair k, Paris p)
            { return p.GetHashCode() >= k.GetHashCode(); }

            //Kiev
            public static bool operator >=(Paris p, Ukrain.Kiev k)
            { return p.GetHashCode() >= k.GetHashCode(); }

            public static bool operator >=(Ukrain.Kiev k, Paris p)
            { return p.GetHashCode() >= k.GetHashCode(); }

      // <=
            public static bool operator <=(Paris p, Kair k)
            { return p.GetHashCode() <= k.GetHashCode(); }

            public static bool operator <=(Kair k, Paris p)
            { return p.GetHashCode() <= k.GetHashCode(); }
        
            //Kiev
            public static bool operator <=(Paris p, Ukrain.Kiev k)
            { return p.GetHashCode() <= k.GetHashCode(); }

            public static bool operator <=(Ukrain.Kiev k, Paris p)
            { return p.GetHashCode() <= k.GetHashCode(); }

    }

}

namespace Egypt
{
    class Kair
    {
        int Popylations = 8026454;

        public override string ToString()
        { return "Kair"; }
        
        public override int GetHashCode()
        { return Popylations;}

        // >
        public static bool operator >(Ukrain.Kiev p,Kair k)
        { return p.GetHashCode() > k.GetHashCode(); }

            public static bool operator >(Kair k , Ukrain.Kiev p )
            { return p>k; }

        // <
        public static bool operator <(Ukrain.Kiev p, Kair k)
        { return p.GetHashCode() < k.GetHashCode();}

            public static bool operator <(Kair k, Ukrain.Kiev p)
            { return p < k; }

        // ==
        public static bool operator ==(Ukrain.Kiev p, Kair k)
            { return p.GetHashCode() == k.GetHashCode(); }

            public static bool operator ==(Kair k, Ukrain.Kiev p )
            { return p.GetHashCode() == k.GetHashCode(); }

       // !=
            public static bool operator !=(Ukrain.Kiev p, Kair k)
            { return p.GetHashCode() != k.GetHashCode(); }

            public static bool operator !=(Kair k, Ukrain.Kiev p)
            { return p.GetHashCode() != k.GetHashCode(); }

       // >=
            public static bool operator >=(Ukrain.Kiev p, Kair k)
            { return p.GetHashCode() >= k.GetHashCode(); }

            public static bool operator >=(Kair k, Ukrain.Kiev p)
            { return p.GetHashCode() >= k.GetHashCode(); }

      // <=
            public static bool operator <=(Ukrain.Kiev p, Kair k)
            { return p.GetHashCode() <= k.GetHashCode(); }

            public static bool operator <=(Kair k, Ukrain.Kiev p)
            { return p.GetHashCode() <= k.GetHashCode(); }
     
    }
}