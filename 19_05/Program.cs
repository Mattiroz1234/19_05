using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer baruch = new Hammer();
            Hammer hammeri = new Hammer();
            Saw saw1 = new Saw();
            Saw saw2 = new Saw();
            NailGun ac = new NailGun();


            Tool[] tools = {baruch, hammeri, ac};
            foreach (var tool in tools)
            {
                tool.Use();
            }
        }
    }
}
