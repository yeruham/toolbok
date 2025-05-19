using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer HammerOne = new Hammer(32);
            Hammer HammerTwo = new Hammer(22, false);
            Saw saw = new Saw(4, false);
            Drill drill = new Drill(6, false);
            Wrench wrench = new Wrench(12);
            List<Tool> tools = new List<Tool> { HammerOne, HammerTwo, saw, drill, wrench };
            foreach (Tool tool in tools)
            {
                tool.Describe();
                tool.Use();
            }


        }
    }
}
