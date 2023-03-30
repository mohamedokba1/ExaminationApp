using System;
using System.Collections.Generic;

namespace ExaminationApp.Models;

public partial class Student
{
    public int StdId { get; set; }

    public string? StdFname { get; set; }

    public string? StdLname { get; set; }

    public byte? StdAge { get; set; }

    public string? StdAddress { get; set; }

    public string? StdEmail { get; set; }

    public string? StdPassword { get; set; }

    public int? DeptId { get; set; }

    public virtual Department? Dept { get; set; }

    public virtual ICollection<StdAnswer> StdAnswers { get; } = new List<StdAnswer>();

    public virtual ICollection<StudExam> StudExams { get; } = new List<StudExam>();

    public virtual ICollection<Course> Crs { get; } = new List<Course>();
}
