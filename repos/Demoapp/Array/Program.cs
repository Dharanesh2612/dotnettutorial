﻿
class program 
{
    private static void Main(string[] args)
    {
        string[] weekdays = { "sun", "mon", "tues", "wed", "thurs", "fri", "satu" };
        Console.WriteLine(weekdays[3]);


        //int daypos = Array.IndexOf(weekdays, "wed");
        //Console.WriteLine(daypos);
        //string[] weekdays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        //Console.WriteLine(weekdays[1]);
        Console.WriteLine(weekdays.Length);
        /* for (int i = 0; i < weekdays.Length; i++)
         {
             Console.WriteLine(weekdays[i]);
         }
        */



        //foreach (string day in weekdays)
        //{
        //    Console.WriteLine(day);
        //}


        //Array.Sort(weekdays);

        //Console.WriteLine("Sorted in Ascending");

        //foreach (string day in weekdays)
        //{
        //    Console.WriteLine(day);
        //}

        //Array.Reverse(weekdays);
        //Console.WriteLine(weekdays);

        //Console.WriteLine("Sorted in Descending ");

        //foreach (string day in weekdays)
        //{
        //    Console.WriteLine(day);
        //}

        //int daypo = Array.IndexOf(weekdays, "Wed");

        //Console.WriteLine("Wednesday is " + (daypo + 1) + " day of week ");

        //Array.Clear(weekdays, 0, 2);

        weekdays[0] = "Sunday";
        Array.Resize(ref weekdays, 7);
        weekdays[6] = "Some Special Day";


        string[] weekdays_copy = new string[7];
        //weekdays.Append("independance day");
        weekdays.CopyTo(weekdays_copy, 0);

        foreach (string day in weekdays_copy)
        {
            Console.WriteLine(day);
        }
    }

}

