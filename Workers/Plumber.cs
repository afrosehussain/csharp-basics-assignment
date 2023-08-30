using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuildingAHouse.Workers
{
    public class Plumber:Worker
    {
        public Plumber(string name, string mobileno)
        {
            Console.WriteLine("Initializing Plumber as: " + name);
            Name = name;
            MobileNo = mobileno;
        }
    }
}
