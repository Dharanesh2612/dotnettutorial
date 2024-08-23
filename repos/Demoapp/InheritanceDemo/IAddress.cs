using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal interface IAddress
    {
        string addressline { get; set; }
        string city {  get; set; }

        string state { get; set; }

  

        string postcode { get; set; }

        void addressDetails();
       
    }



}
