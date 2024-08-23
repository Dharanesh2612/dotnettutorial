using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskIheritance
{
    internal class Shop : IOutlet, IProduct
    {

        public string Shop_name { get; set; }
        public string Outlet_name { get  ; set  ; }
        public string Outlet_city { get  ; set  ; }
        public string Outlet_location { get  ; set  ; }
        public string product_name { get  ; set  ; }
        public int product_price { get  ; set  ; }
        public string product_category { get  ; set  ; }

        public void shopname()
        {
            Console.WriteLine("shop_name :" + this.Shop_name);
        }

        public void getOutletDetails()
        {
            Console.WriteLine("outlet_name : " + this.Outlet_name);
            Console.WriteLine("outlet_city : " + this.Outlet_city);
            Console.WriteLine("outlet_location : " + this.Outlet_location);

        }

        public void getProductDetails()
        {
            Console.WriteLine("product_name : " + this.product_name);
            Console.WriteLine("product_price : " + this.product_price);
            Console.WriteLine("product_category : " + this.product_category);
        }
    }
}
