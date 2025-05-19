using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05
{
    internal class ToolBox
    {
        Tool[] Tools;

        public ToolBox(Tool[] tools)
        {
            Tools = tools;
        }

        public void Print() 
        {
            foreach (var tool in Tools)
            {
                Console.WriteLine(tool.Name);
            }
        }
    }
}

