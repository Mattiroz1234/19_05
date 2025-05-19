using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05
{
    internal class Hammer : Tool
    {
        public override string Name { get; set; }
        public override string Weight { get; set; }
        public int useCount = 0;

        public override void Describe()
        {
            Console.WriteLine("Used to hit things or drive nails");
        }
        public override void Use()
        {
            useCount++;
            Console.WriteLine("Hammer in action – striking force applied!");
        }
    }
}
