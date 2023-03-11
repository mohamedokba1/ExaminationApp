using System;
using System.Collections.Generic;

namespace ExaminationApp.Models;

public partial class StudAnswer
{
    public int AnsId { get; set; }

    public int? StId { get; set; }

    public int? QuesId { get; set; }

    public int? ExamId { get; set; }

    public string? SelectedAnswer { get; set; }

    public virtual Exam? Exam { get; set; }

    public virtual Question? Ques { get; set; }

    public virtual Student? St { get; set; }
}
