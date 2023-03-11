using System;
using System.Collections.Generic;

namespace ExaminationApp.Models;

public partial class QuesChoice
{
    public int QuesId { get; set; }

    public string Choice { get; set; } = null!;

    public virtual Question Ques { get; set; } = null!;
}
