using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal interface IContact
    {
        string email { get; set; }
        string phonenumber {  get; set; }



        void getcontactdetails();
        
    }
}
