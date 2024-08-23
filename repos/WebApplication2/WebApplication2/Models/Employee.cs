using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class Employee
{
    public int Id { get; set; }

    public int? Departmentid { get; set; }

    public string? Name { get; set; }

    public string? Designation { get; set; }

    public virtual Department? Department { get; set; }
}
