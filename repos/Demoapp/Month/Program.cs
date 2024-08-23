class program
{
    private static void Main(string[] args)
    {
        string[] month = { "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec" };

        Console.WriteLine(month[5]);



        //sort

        Array.Sort(month);
        foreach (string months in month)
        {
            Console.WriteLine(months);
        }

        Console.WriteLine("========================");

        //reverse
        Array.Reverse(month);
        foreach (string months in month)
        {
            Console.WriteLine(months);
        }
        Console.WriteLine("========================");


        //index of particular month
        int monthofnumber = Array.IndexOf(month, "july");
        Console.WriteLine("this is the month " + (monthofnumber) + "year");

        //clear
        Array.Clear(month, 0, 4);
        foreach (string monthh in month) {
            Console.WriteLine(monthh);
        }

        //Inserting a value in one particular index
        Console.WriteLine("Inserting one value from the array :");
        month[0] = "jun";
        foreach (string mon in month)
        {
            Console.WriteLine(mon);
        }


        //Copy Array
        Console.WriteLine("Copying to Another Array");
        string[] copy_months = new string[12];
        month.CopyTo(copy_months, 0);

        foreach (string cmon in copy_months)
        {
            Console.WriteLine(cmon);
        }


    }





}
    
