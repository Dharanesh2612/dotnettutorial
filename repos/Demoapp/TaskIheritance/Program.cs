namespace TaskIheritance;

class Program
{

    private static void Main(string[] args)
    {
        //Shop s = new Shop();
        //s.Shop_name = "dharshan";
        //s.product_name = "boomerrrr";
        //s.product_price =25 ;
        //s.Outlet_name = "hiii dudeee";
        //s.Outlet_city = "madurai";
        //s.Outlet_location = "keelarathi veethi";
        //s.product_category = "eatingggg";
        //s.getProductDetails();
        //s.getOutletDetails();
        //s.shopname();


        Shop shop = new Shop();
        shop.Shop_name = "MSI";
        shop.product_name = "MSI Thin 15";
        shop.product_price = 52000;
        shop.product_category = "Gaming Laptop";
        shop.Outlet_name = "MSI FACTORY";
        shop.Outlet_city = "Thaiwanese";
        shop.Outlet_location = "China";
        shop.getProductDetails();
        shop.getOutletDetails();
    }

}
