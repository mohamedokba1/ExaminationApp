using System;
using System.Collections.Generic;

namespace ExaminationApp.Models;

public partial class Department
{
    public int DeptId { get; set; }

    public string? DeptName { get; set; }

    public virtual ICollection<Instructor> Instructors { get; } = new List<Instructor>();

    public virtual ICollection<Student> Students { get; } = new List<Student>();
}
