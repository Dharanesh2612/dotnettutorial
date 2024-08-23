using System.ComponentModel;

public delegate void calloutmyname(string username);

class publisherDemo
{
    public event calloutmyname callname;

    public void raiseEvent(string username)
    {
        callname(username);
    }
}
class subscriberDemo
{
    public void subscribercallname(string username)
    {
        Console.WriteLine("Good Morning : " + username);
    }

    public void connect()
    {
        publisherDemo pc = new publisherDemo();
        pc.callname += subscribercallname;
        pc.raiseEvent("Sura");
        pc.raiseEvent("vijay");

    }

}







class DelegatesDemo
{
    public void Add(int a, int b)
    {
        int c = a + b;
        Console.WriteLine("Sum of " + a + " + " + b + " = " + c);
    }




    public void multiply(int a, int b)
    {
        int c = a * b;
        Console.WriteLine("Multiply of " + a + " * " + b + " = " + c);
    }

    public void substract(int a, int b)
    {
        int c = a - b;
        Console.WriteLine("substract of " + a + " - " + b + " = " + c);
    }


    public void divide(int a, int b)
    {
        int c = a / b;
        Console.WriteLine("divide of " + a + " - " + b + " = " + c);
    }


}
public delegate void numberopersations(int a, int b);



internal class Program
{
    private static void Main(string[] args)
    {
        //numberopersations no;
        //DelegatesDemo dd = new DelegatesDemo();
        //no = dd.Add;
        //no(20, 30);
        ////no += dd.substract;
        ////no += dd.multiply;
        //no += dd.substract;// no = no+dd.substract
        //no(20, 30);
        //no = dd.multiply;
        //no(30, 20);

        subscriberDemo sc = new subscriberDemo();
        sc.connect();

    }
}

//class DelegateDemo
//{


    
     
//    public void Add(int a,int b) 
//    {
//        int c = a + b;
//        Console.WriteLine( c);
//    }    

//    public void multiply(int a ,int b)
//    {
//        int c = a * b;
//        Console.WriteLine( c);
//    }

//    public void Subtract(int a, int b)
//    {
//        int c = a - b;
//        Console.WriteLine( c);
//    }

//    public delegate void sumofvalues(int a, int b);
//    private static void Main(string[] args)
//    {
//        sumofvalues dd;
//        DelegateDemo Ad =new DelegateDemo();
//        dd = Ad.Add;
//        dd =dd+Ad.Subtract;
//        dd = dd+Ad.multiply;
//        dd(20, 30);
//    }
//}