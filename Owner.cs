using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingAHouse
{   
    //There is only a single owner, no class can inherit it. So, I used the sealed keyword here
    public sealed class Owner
    {   
        public string Name { get; set; }
        public string? Address { get; set; }
        public string MobileNo { get; set; }

        //Constructor Overloading
        public Owner(string _name, string _mobile)
        {
            Console.WriteLine("Initializing owner as: " + _name);
            Name = _name;
            MobileNo = _mobile;
        } 
        public Owner(string _name, string _mobile, string _address) {
            Console.WriteLine("Initializing owner as: " + _name);
            Name = _name;
            Address = _address;
            MobileNo = _mobile;
        }

        private void PayingTheExpenses()
        {
            Console.WriteLine(Name + " Pays the workers");
        }

        private void SupervisesTheWorkers()
        {
            Console.WriteLine(Name + " Supervises all the workers");
        }

        public void GetDetails()
        {
            PayingTheExpenses();
            SupervisesTheWorkers();
        }

        //Changing the value of variables, initialized using constructor using method
        public void UpdateAddress(string _address)
        {
            Address = _address;
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
