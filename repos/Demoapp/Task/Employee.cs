using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Employee : Person
    {
        public int empId { get; set; }
        public double salary { get; set; }

        public Employee(string firstName, string lastName, string gender, int empId, int salary) : base(firstName, lastName, gender)
        {
            this.empId = empId;
            this.salary = salary;
        }

        public override string  displayDetails()
        {
            return "EmpID : " + empId + " FullName : " + this.firstName + " " + this.lastName + "  Gender : " + this.gender + "  Salary : " + salary;

        }


        //POLYMORPHISM
        //public void displayDetails()
        //{
        //    Console.WriteLine("Employee Id :" + this.empId);
        //    base.displayDetails();
        //    Console.WriteLine("Employee Salary : " + this.salary);
        //}

    }
    //public string employeeName;
    //public int age;
    //public double salary;
    //public string company;

    //public Employee(string employeeName, int age)
    //{
    //    this.employeeName = employeeName;
    //    this.age = age;
    //}

    //public Employee(string employeeName, int age, double salary)
    //{
    //    this.employeeName = employeeName;
    //    this.age = age;
    //    this.salary = salary;
    //}
    //public Employee(string employeeName, int age, double salary, string company)
    //{
    //    this.employeeName = employeeName;
    //    this.age = age;
    //    this.salary = salary;
    //    this.company = company;
    //}


}








