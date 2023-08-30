using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuildingAHouse.Workers
{
    public class Mason : Worker, ICementWorker
    {
        public Mason(string name, string mobileno) {
            Console.WriteLine("Initializing mason as: " + name);
            Name = name;
            MobileNo = mobileno;
        }
        public override void UsesWater()
        {
            Console.WriteLine(Name + "  uses water for watering the building and mixing mortar");
        }
        public void UsesCement()
        {
            Console.WriteLine(Name + "  uses Cement for making mortar and plastering");
        }
    }
}
