
using System.Diagnostics.Contracts;

//class Program
//{

//    private static void Main(string[] args)
//    {


//Console.WriteLine("Hello, World!");

//Console.ReadKey();
//Console.WriteLine("this is num1");
//Console.Clear();
//Console.WriteLine("this is num2");

//sbyte a = 10;
//byte b= 20;
//short s = 30;
//ushort d = 30;
//int i = 30;
//float e = 2.45f;


//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(s);
//Console.WriteLine(d);
//Console.WriteLine(i);

//int max = int.MinValue;
//int MIN= int.MaxValue;

//Console.WriteLine(max);
//Console.WriteLine(MIN);


//uint max = uint.MinValue;
//uint MIN = uint.MaxValue;

//Console.WriteLine(max);
//Console.WriteLine(MIN);


//char ch='a';
//string str = "i am a boy";

//Console.WriteLine(ch);

//Console.WriteLine(str);

//int a = 35; int b = 45;
//Console.WriteLine(a + b);
//Console.WriteLine(a - b);
//Console.WriteLine(a * b);
//Console.WriteLine(a % b);
//Console.WriteLine(a / b);


//double a = 35; double b = 45;
//Console.WriteLine(a =+ b);
//Console.WriteLine(a = +b);

//Console.WriteLine(a = -b);
//Console.WriteLine(a *= b);
//Console.WriteLine(a %= b);
//Console.WriteLine(a /= b);

//int x = 10,y = 20,z = 30;
//bool result =((x==y) && (y==z));
//Console.WriteLine(result);
//bool result1 =((x==y) || (y==z));
//Console.WriteLine(result1);
//bool result2 = !result;
//Console.WriteLine(result2);

//int num1 = 34;
//string result=((num1%2 == 0)?  "even":"odd");
//Console.WriteLine(result);


//int x = 1999;
//if ((x % 400 ==0) ||( (x %4 ==0) && (x % 100!=0))) 
//{
//    Console.WriteLine(x + "THIS is LEAP YEAR");
//}
//else
//{
//    Console.WriteLine(x + "this is not leap year");
//}




//int mark = 16;

//if (mark >= 75) 
//{ Console.WriteLine("discccc");
//}
//else if (mark >= 60 && mark < 74)
//{
//    Console.WriteLine("good mark");
//}
//else if (mark >= 35 && mark < 60)
//{
//    Console.WriteLine("just pass");
//}
//else
//{
//    Console.WriteLine("FAIL");
//}



//int num1 = 4050,num2 = 23000,num3 = 6400;

//if (num1 >= num2 && num1 >= num3)
//{ Console.WriteLine("num1 is greatest one"); }
//else if ( num2 >= num3)
//{ Console.WriteLine("num2 is greatest one"); }
//else
//{
//    Console.WriteLine("num3 is greatest one");
//}

//string monthname = "month";
//int monthno = 10;

//switch (monthno)
//{
//    case 1:monthname = "jan";break;
//    case 2: monthname = "feb"; break;
//    case 3: monthname = "mar"; break;
//    case 4: monthname = "apr"; break;
//    case 5: monthname = "may"; break;
//    case 6: monthname = "jun"; break;
//    case 7: monthname = "jul"; break;
//    case 8: monthname = "aug"; break;
//    case 9: monthname = "sep"; break;
//    case 10: monthname = "oct"; break;
//    case 11: monthname = "nov"; break;
//    case 12: monthname = "dec"; break;
//    default:monthname = "wrong month";break;
//}
//Console.WriteLine(monthname);



//int num = 6;
//int fact = 1;

//while(num > 1)
//{
//    fact *= num;
//    num--;
//}

//Console.WriteLine("factorial of 5 is " + fact);

//int i = 1;
//int summ0fodd = 0;
//do
//{
//    if (i % 2 == 1)
//    {
//        summ0fodd += i;
//    }
//    i++;
//} while (i < 100);
//Console.WriteLine("sum of odd number is " + summ0fodd);


//int sumofodd = 0;
//for(int i = 0; i < 100; i++) 
//{
// if(i % 2 == 1)
//    {
//        sumofodd +=i;
//    }

//}
//Console.WriteLine(sumofodd);

//int num = 64351;

//int value = 0;
//int sum = 0;
//while (num > 0)
//{
//    value = num % 10;
//    sum += value;
//    num = num / 10;
//}

//Console.WriteLine(sum);



//int num = 198;
//int count = 0;

//for (int i = 1; i <= num; i++)
//    {
//        if (num % i == 0)
//        {
//            count++;
//        }

//    }
//    if (count > 2)
//    {
//        Console.WriteLine(num + "  is not Prime NUmber");
//    }
//    else
//    {
//        Console.WriteLine(num + "  is  Prime NUmber");
//    }






//int num = 64381;

//int sum = 0;
//while (num > 0)
//{
//     int value = num % 10;
//    sum += value;
//    num = num / 10;
//}

//Console.WriteLine(sum);

//}
//}
//ACCESS MODIFIERS IN .NET 
class Student
{
    private int std_id;
    protected int yob;
    internal int age;
    protected internal string gender;
    public string fname;

    public string getDetails()
    {
        std_id = 1;//Private members is accesible in the same class only.
        yob = 2001;//protected members is accessible in the same class and child class.
        age = 21;//Internal is accessible in same file but not other file .
        gender = "male";
        fname = "siva";//public members is accessible in any class

        return "ID:" + std_id + "YOB :" + yob + " AGE :" + age + " GENDER:" + gender + "FIRST_NAME :" + fname;
    }
}

class School : Student
{
    public string schoolName;
    public string getDetailsWithSchool()
    {

        yob = 2001;//protected members is accessible in the same class and child class.
        age = 21;
        gender = "male";
        fname = "dharan";//public members is accessible in any class
        schoolName = "cvmis";
        return "YOB :" + yob + " AGE :" + age + " GENDER:" + gender + "FIRST_NAME :" + fname + "SCHOOL_NAME :" + schoolName;
    }

}
class Parent
{
    public string getStudentDetails()
    {
        Student student = new Student();
        student.fname = "nesh";
        student.age = 23;
        student.gender = "Male";
        return "STUDENT_FNAME :" + student.fname + "STUDENT_AGE :" + student.age + "STUDENT_GENDER :" + student.gender;
    }
}

class Program
{
    private static void Main(string[] args)
    {


        Student student = new Student();
        string d1 = student.getDetails();
        Console.WriteLine(d1);
        School school = new School();
        string d2 = school.getDetailsWithSchool();
        Console.WriteLine(d2);
        Parent parent = new Parent();
        string d3 = parent.getStudentDetails();
        Console.WriteLine(d3);

    }
}



