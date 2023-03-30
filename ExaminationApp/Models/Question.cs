using System;
using System.Collections.Generic;

namespace ExaminationApp.Models;

public partial class Question
{
    public int QuesId { get; set; }

    public string QuesBody { get; set; } = null!;

    public string QuesType { get; set; } = null!;

    public string? CorrectAnswer { get; set; }

    public int? Mark { get; set; }

    public string? ChoiceA { get; set; }

    public string? ChoiceB { get; set; }

    public string? ChoiceC { get; set; }

    public int? CrsId { get; set; }

    public virtual Course? Crs { get; set; }

    public virtual ICollection<StdAnswer> StdAnswers { get; } = new List<StdAnswer>();

    public virtual ICollection<Exam> Exams { get; } = new List<Exam>();
}
