using System;
using System.Collections.Generic;

namespace ExaminationApp.Models;

public partial class StudExam
{
    public int StId { get; set; }

    public int ExamId { get; set; }

    public int? StScore { get; set; }

    public DateTime? ExamDate { get; set; }

    public string? Status { get; set; }

    public virtual Exam Exam { get; set; } = null!;

    public virtual Student St { get; set; } = null!;
}
