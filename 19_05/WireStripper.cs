using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05
{
    internal class WireStripper:Tool
    {
        public override string Name { get; set; }
        public override string Weight { get; set; }
        public int useCount = 0;

        public override void Describe()
        {
            Console.WriteLine("Removes insulation from electrical wires.");
        }
        public override void Use()
        {
            useCount++;
            Console.WriteLine("Stripping wire – exposing clean copper."

);
        }
    }
}
