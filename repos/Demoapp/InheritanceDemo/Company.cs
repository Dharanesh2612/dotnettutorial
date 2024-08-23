using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Company : IAddress, IContact
    {
        public string addressline { get ; set; }
        public string city { get; set ; }
        public string state { get ; set ; }
        public String postcode { get ; set ; }
       
        public string email { get ; set ; }
        public string phonenumber { get ; set ; }

        public void addressDetails()
        {
            Console.WriteLine("Company Name: " + this.email);
            Console.WriteLine("Address Line 1: " + this.phonenumber + "\n" + "City: " + this, city + "\n" + "State: " + this.state + "\n" + "PostCode: " + this.postcode);
        }

        public void getcontactdetails()
        {
            Console.WriteLine("Email: " + this.email + "\n" + "Mobile Number:" + this.phonenumber);
        }
    }
}
