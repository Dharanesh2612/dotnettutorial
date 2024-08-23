using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Employee : IContact, IAddress
    {
        public string email { get ; set; }
        public string phonenumber { get; set; }
        public string addressline { get ; set; }
        public string city { get ; set ; }
        public string state { get; set ; }
        public string postcode { get ; set ; }

        public void addressDetails()
        {
           
        }

        public void getcontactdetails()
        {
          
        }
    }
}
