using System;
using System.Collections.Generic;

namespace ExaminationApp.Models;

public partial class StdAnswer
{
    public int AnsId { get; set; }

    public int QuesId { get; set; }

    public int? ExamId { get; set; }

    public int? StdId { get; set; }

    public string? SelectedAnswer { get; set; }

    public virtual Exam? Exam { get; set; }

    public virtual Question Ques { get; set; } = null!;

    public virtual Student? Std { get; set; }
}
