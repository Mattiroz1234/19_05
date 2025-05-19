using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05
{
    internal class NailGun:Tool
    {
        public override string Name { get; set; }
        public override string Weight { get; set; }
        public int useCount = 0;

        public override void Describe()
        {
            Console.WriteLine("Shoots nails quickly using air or power.");
        }
        public override void Use()
        {
            useCount++;
            Console.WriteLine("Firing nail – hold steady!");
        }
    }
}
