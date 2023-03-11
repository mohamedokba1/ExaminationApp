using System;
using System.Collections.Generic;

namespace ExaminationApp.Models;

public partial class Exam
{
    public int ExamId { get; set; }

    public int? PassScore { get; set; }

    public int? ExamDuration { get; set; }

    public int? CrsId { get; set; }

    public virtual Course? Crs { get; set; }

    public virtual ICollection<StudAnswer> StudAnswers { get; } = new List<StudAnswer>();

    public virtual ICollection<Question> Ques { get; } = new List<Question>();
}
