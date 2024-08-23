using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskIheritance
{
    internal interface IProduct
    {
        public string product_name { get; set; }
        public int product_price { get; set; }
        public string product_category { get; set; }

        void getProductDetails();



    }
}
