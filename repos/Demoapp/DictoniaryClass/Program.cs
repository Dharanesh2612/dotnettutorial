class Program
{

    private static void Main(string[] args)

    {

        Dictionary<int, string> empdetails;

        empdetails = new Dictionary<int, string>();

        empdetails.Add(100, "Parag");

        empdetails.Add(102, "Prachi");

        empdetails.Add(103, "Manas");

        string ename = empdetails[102];

        Console.WriteLine(ename);

        SortedList<string, int> Marks;

        Marks = new SortedList<string, int>();

        Marks.Add("Maths", 80);

        Marks.Add("Physics", 90);

        Marks.Add("English", 65);

        Marks.Add("Chemistry", 75);

        foreach (string key in Marks.Keys)

        {

            Console.WriteLine(Marks[key]);

        }
        Console.WriteLine("If the key 3 is present?{0}", Marks.ContainsKey("Maths"));

      //REMOVE
        Marks.Remove("Chemistry");


        foreach (string key in Marks.Keys)

        {

            Console.WriteLine(Marks[key]);

        }
        //CONTAINS
        Console.WriteLine(Marks.ContainsKey("English"));


        //containsvalue
        Console.WriteLine(Marks.ContainsValue(75));
    }
}
           
