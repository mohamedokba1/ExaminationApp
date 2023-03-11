using System;
using System.Collections.Generic;

namespace ExaminationApp.Models;

public partial class Question
{
    public int QuesId { get; set; }

    public string? QuesBody { get; set; }

    public string? QuesType { get; set; }

    public string? CorrectAnswer { get; set; }

    public int? Mark { get; set; }

    public int? CrsId { get; set; }

    public virtual Course? Crs { get; set; }

    public virtual ICollection<QuesChoice> QuesChoices { get; } = new List<QuesChoice>();

    public virtual ICollection<StudAnswer> StudAnswers { get; } = new List<StudAnswer>();

    public virtual ICollection<Exam> Exams { get; } = new List<Exam>();
}
