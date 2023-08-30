using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingAHouse.Workers
{
    public abstract class Worker
    {
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public void Working()
        {
            Console.WriteLine(Name + " is working");
        }
        public void GettingPaidByOwner()
        {
            Console.WriteLine(Name + " is getting paid by the owner");
        }
        public virtual void UsesWater()
        {
            Console.WriteLine(Name + "  generally doesn't need water for his work");
        }
        public string GetName()
        {
            return Name;
        }
        public string GetMobileNo()
        {
            return MobileNo;
        }
    }
}
