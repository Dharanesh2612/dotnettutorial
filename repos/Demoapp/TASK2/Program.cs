using System;
using System.Collections.Generic;

class Program
{
    private static void Main(string[] args)
    {

        List<string> products = new List<string>() { "Butter", "Bread", "Milk", "Cheese" };
        List<int> prices = new List<int>() { 200, 24, 50, 31 };

      

        while (true)
        {
            Console.WriteLine("\nClick the procedure for doing the process:");
            Console.WriteLine("1. Update the data");
            Console.WriteLine("2. Remove the data");
            Console.WriteLine("3. Show the list");
            Console.WriteLine("4. add");
            Console.WriteLine("5. exit");

            Console.Write("Write the process you want (1/2/3/4/5): ");
            string data = Console.ReadLine();

            switch (data)
            {
                case "1":
                    UpdateProduct(products, prices);
                    break;

                case "2":
                    RemoveProduct(products, prices);
                    break;

                case "3":
                    ShowList(products, prices);
                    break;


                case "4":
                    AddProduct(products, prices);
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void UpdateProduct(List<string> products, List<int> prices)
    {
        Console.Write("Enter the name of the product to be updated: ");
        string oldProduct = Console.ReadLine();
        int index = products.IndexOf(oldProduct);

        if (index != -1)
        {
            Console.Write("Enter the new name for the product: ");
            string newProduct = Console.ReadLine();

            Console.Write("Enter the new price for the product: ");
            int newPrice = Convert.ToInt32(Console.ReadLine()); 

            products[index] = newProduct;
            prices[index] = newPrice;

            Console.WriteLine("Product updated successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }


static void RemoveProduct(List<string> products, List<int> prices)
    {
        Console.Write("Enter the name of the product to be removed: ");
        string productToRemove = Console.ReadLine();
        if (products.Contains(productToRemove))
        {
            products.Remove(productToRemove);
            Console.WriteLine("removed successfully.");
        }

        else
        {
            Console.WriteLine("Removal canceled.");
        }
    }
    static void AddProduct(List<string> products, List<int> prices)
    {
        
       
        
            Console.Write("Enter the new name for the product: ");
            string newProduct = Console.ReadLine();

            Console.Write("Enter the new price for the product: ");
            int newPrice = Convert.ToInt32(Console.ReadLine());


            products.Add(newProduct);
            prices.Add(newPrice);


            Console.WriteLine("Product updated successfully.");
        }


        static void ShowList(List<string> products, List<int> prices)
    {
        Console.WriteLine("List of products and prices:");
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine(products[i] + "price for this food is" + prices[i]);
        }
    }

}
