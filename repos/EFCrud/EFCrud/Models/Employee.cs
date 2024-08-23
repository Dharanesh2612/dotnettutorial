namespace EFCrud.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Designation { get; set; }

        public int departmentId { get; set; }
        public Department Department { get; set; }
    }
}

