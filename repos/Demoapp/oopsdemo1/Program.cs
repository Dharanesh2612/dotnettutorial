
using oopsdemo1;

namespace Task;
class Program
{

    private static void Main(string[] args)

    {

        User u1, u2, u3, u4;

        //for (int i = 0; i < 3; i++)
        {
            Console.Write("enter username : ");
            string username = Console.ReadLine();
            Console.Write("Enter password : ");
            string password = Console.ReadLine();
            u1 = new User(username, password);
            string result = u1.CheckLogin();
            u1.getDetails();
            Console.WriteLine(result);



            u2 = new User("dhar", "nesh", "hlo this is");
            u2.getDetails();

            result = u2.CheckLogin();
            Console.WriteLine(result);

            u3 = new User("dharan", "joshi", "hi user", "pune");
            u3.getDetails();
            result = u3.CheckLogin();
            Console.WriteLine(result);

            u4 = new User("kama", "lesh", "hii specisl user", "madurai", false);
            u4.getDetails();
            result = u4.CheckLogin();
            Console.WriteLine(result);

        }












































        //        //Student s1, s2;
        //        //s1 = new Student();
        //        // s2 = new Student();

        //        //s1.studentId = 1;
        //        //s1.studentName = "dharanesh";
        //        //s1.marks = 77;

        //        //s2.studentId = 2;
        //        //s2.studentName = "dharan";
        //        //s2.marks = 97;


        //        //Student.collegename = "JIT";

        //        //Console.WriteLine("collegename :" + Student.collegename);
        //        //Console.WriteLine("student Id:"+ s1.studentId);
        //        //Console.WriteLine("student name:" +s1.studentName);
        //        //Console.WriteLine("student marks" + s1.marks);
        //        //Console.WriteLine();
        //        //Console.WriteLine("collegename :" + Student.collegename);
        //        //Console.WriteLine("student Id:" + s2.studentId);
        //        //Console.WriteLine("student name:" + s2.studentName);
        //        //Console.WriteLine("student marks" + s2.marks);
        //        //Console.WriteLine();

        //        Employee e1, e2;
        //        e1=new Employee();
        //        e2=new Employee();


        //        e1.employeeSalary = 34500;
        //        e1.employeeName = "dharan";
        //        e1.employeeAge = 23;


        //        e2.employeeAge = 24;
        //        e2.employeeSalary = 35000;
        //        e2.employeeName = "neshwar";

        //        Employee.employeeCompanyName = "Changepond";          

        //        Console.WriteLine("companyname:"+Employee.employeeCompanyName);
        //        Console.WriteLine("employeename: "+ e1.employeeName);
        //        Console.WriteLine("employeeage: " + e1.employeeAge);
        //        Console.WriteLine("EMPLOYEESALARY: " + e1.employeeSalary);
        //        Console.WriteLine("companyname:" + Employee.employeeCompanyName);
        //        Console.WriteLine("employeename: " + e2.employeeName);
        //        Console.WriteLine("employeeage: " + e2.employeeAge);
        //        Console.WriteLine("EMPLOYEESALARY: " + e2.employeeSalary);
        //    }
    }


}