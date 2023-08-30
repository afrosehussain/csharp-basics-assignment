using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuildingAHouse.Workers
{
    public class TileLayer : Worker, ICementWorker
    {
        public TileLayer(string name, string mobileno)
        {
            Console.WriteLine("Initializing Tile Layer as: " + name);
            Name = name;
            MobileNo = mobileno;
        }
        public override void UsesWater()
        {
            Console.WriteLine(Name + "  uses water for soaking tiles and mixing mortar");
        }
        public void UsesCement()
        {
            Console.WriteLine(Name + "  uses cement for laying tiles");
        }

    }
}
