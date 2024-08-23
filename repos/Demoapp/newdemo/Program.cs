namespace newdemo;

class Program
{
    private static void Main(string[] args)
    {
        Product p1, p2, p3, p4;
        p1 = new Product() { Id = 1, Name = "SHIRTS", Price = 250 };
        p2 = new Product() { Id = 2, Name = "trousers", Price = 400 };
        p3 = new Product() { Id = 3, Name = "t-shirts", Price = 300 };
        p4 = new Product() { Id = 4, Name = "b-t-shirts", Price = 310 };

        List<Product> products = new List<Product>() { p1, p2, p3, p4 };
        List<Product> Cartlist = new List<Product>() { };

        for (int i = 0; i < products.Count; i++)
        {
            Product product = products[i];
            if (product.Price > 300)
            {
                Cartlist.Add(product);
                  
            }
        }

        for (int i = 0; i < Cartlist.Count; i++)
        {
            Product product = Cartlist[i];
            Console.WriteLine(product.Name + " " + product.Price);
        }


    }
}