using System;
using System.Collections.Generic;

namespace ExaminationApp.Models;

public partial class Exam
{
    public int ExamId { get; set; }

    public int? PassScore { get; set; }

    public int? ExamDuration { get; set; }

    public int CrsId { get; set; }

    public virtual Course Crs { get; set; } = null!;

    public virtual ICollection<StdAnswer> StdAnswers { get; } = new List<StdAnswer>();

    public virtual ICollection<StudExam> StudExams { get; } = new List<StudExam>();

    public virtual ICollection<Question> Quests { get; } = new List<Question>();
}
