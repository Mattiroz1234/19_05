using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05
{
    internal abstract class Tool
    {
        public abstract string Name { get; set; }
        public abstract string Weight { get; set; }
        

        public abstract void Describe();
        public abstract void Use();
    }
}
