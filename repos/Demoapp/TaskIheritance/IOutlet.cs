using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskIheritance
{
    internal interface IOutlet
    {
        public string Outlet_name { get; set; }
        public string Outlet_city { get; set; }

        public string Outlet_location { get; set; }

        void getOutletDetails();






    }
}
