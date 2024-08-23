using System.Collections.Generic;

class program
{
    private static void Main(string[] args)
    {
        //List<int> ints = new List<int>() { 23,24,25,27,29 };
        //List<int> even = new List<int>() ;

        //even =(from item  in ints where(item%2==0) select item).ToList() ;
        //foreach(int i in even)
        //{
        //    Console.WriteLine(i);
        //}

        List<string> products = new List<string>() { "Butter", "Bread", "Milk", "Cheese" };
       
        List<string> product = new List<string>();
        Console.WriteLine("write the product");
        string foods = Console.ReadLine();
          
        
        product =(from item in  products where(foods.Contains(item)) select item).ToList();

        foreach(string i in product)
        {
            Console.WriteLine(" this products present in product "+ i);
        }
       

    }
}