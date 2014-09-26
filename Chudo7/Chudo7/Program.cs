using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Babylonians;
using Carians;
using Egyptians;
using Greeks;
using Lydians;
using PtolemanicEgyptians;

namespace Chudo7
{
    class Program
    {
        static void Main(string[] args)
        {
            HangingGardensOfBabylon Ch1 = new HangingGardensOfBabylon();
            Console.WriteLine(Ch1+"\n\n");

            MausoleumAtHalicarnassus Ch2 = new MausoleumAtHalicarnassus();
            Console.WriteLine(Ch2 + "\n\n");

            GreatPyramidOfGiza Ch3 = new GreatPyramidOfGiza();
            Console.WriteLine(Ch3 + "\n\n");

            StatueOfZeusAtOlympia Ch4 = new StatueOfZeusAtOlympia();
            Console.WriteLine(Ch4 + "\n\n");

            ColossusOfRhodes Ch5 = new ColossusOfRhodes();
            Console.WriteLine(Ch5 + "\n\n");

            TempleOfArtemisAtEphesus Ch6 = new TempleOfArtemisAtEphesus();
            Console.WriteLine(Ch6 + "\n\n");

            LighthouseOfAlexandria Ch7 = new LighthouseOfAlexandria();
            Console.WriteLine(Ch7 + "\n\n");
        }
    }
}
