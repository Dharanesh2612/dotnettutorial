//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Task
//{
//    internal class Student : Person
//    {
        
//            public int studentId { get; set; }
//        public int marks { get; set; }

//        //    public void DisplayStudentDetails()
//        //    {
//        //        Console.WriteLine("student_name :" + base.firstName);
//        //        Console.WriteLine("STUDENT_LASTNAME: " + base.lastName);
//        //        Console.WriteLine("STUDENT gender: " + base.gender);
//        //        Console.WriteLine("student_id : " + base.studentId);
//        //    }

//        //}
//        public Student(string firstName, string lastName, string gender, int studentId, int marks) : base(firstName, lastName, gender)
//        {
//            this.studentId = studentId;
//            this.marks = marks;
//        }


//        //POLYMORPHISM
//        public void displayDetails()
//        {
//            base.displayDetails();
//            Console.WriteLine("Student Id :" + this.studentId);
//            Console.WriteLine("Student Marks : " + this.marks);
//        }


//    }

//}