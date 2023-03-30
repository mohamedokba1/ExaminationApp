using System;
using System.Collections.Generic;

namespace ExaminationApp.Models;

public partial class Course
{
    public int CrsId { get; set; }

    public string? CrsName { get; set; }

    public int? CrsDuration { get; set; }

    public int? TopicId { get; set; }

    public virtual ICollection<Exam> Exams { get; } = new List<Exam>();

    public virtual ICollection<Question> Questions { get; } = new List<Question>();

    public virtual Topic? Topic { get; set; }

    public virtual ICollection<Instructor> Ins { get; } = new List<Instructor>();

    public virtual ICollection<Student> Stds { get; } = new List<Student>();
}
