using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuildingAHouse.Workers
{
    public class Electrician:Worker
    {
        public Electrician(string name, string mobileno)
        {
            Console.WriteLine("Initializing electrician as: " + name);
            Name = name;
            MobileNo = mobileno;
        }
    }
}
