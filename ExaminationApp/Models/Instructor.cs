using System;
using System.Collections.Generic;

namespace ExaminationApp.Models;

public partial class Instructor
{
    public int InsId { get; set; }

    public string? InsName { get; set; }

    public string? InsEmail { get; set; }

    public string? InsPassword { get; set; }

    public int? DeptId { get; set; }

    public virtual Department? Dept { get; set; }

    public virtual ICollection<Course> Crs { get; } = new List<Course>();
}
