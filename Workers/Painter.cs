using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuildingAHouse.Workers
{
    public class Painter: Worker
    {
        public Painter(string name, string mobileno)
        {
            Console.WriteLine("Initializing painter as: " + name);
            Name = name;
            MobileNo = mobileno;
        }
        public override void UsesWater()
        {
            Console.WriteLine(Name + "  uses water to dilute paint mixtures");
        }
    }
}
