class Address
{
    public class Contact
    {
        private string street = "Rahatani";
        public void getContact()
        {
            Console.WriteLine(street + " Pune-411017");
        }
    }
}
class Program
{
    private static void Main(string[] args)
    {
        Address.Contact c = new Address.Contact();
        c.getContact();

        /*       var numbers = new int[] { 2, 3, 5, 7, 9 ,5};
                //inline lamdas or expression lamdas
                var count = numbers.Count(x => x ==5 );
               // Console.WriteLine(count);
                List<int> numbers1 = new List<int> { 2, 7, 5, 8, 1, 6, 5, 8, 9, 1 };
              //Statement lamdas
                int count1 = numbers1.Count(x =>
                {
                    return x == 5;
                });
                //Console.WriteLine(count1);
                Func<int, int> squareDelegate = x => x * x;
                Console.WriteLine(squareDelegate(2));
                Func<int, int> exampleDelegate = (x =>
                {
                    return x * x;
                });
                Console.WriteLine(exampleDelegate(2));*/
    }
}