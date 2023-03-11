using System;
using System.Collections.Generic;

namespace ExaminationApp.Models;

public partial class StudCourse
{
    public int StId { get; set; }

    public int CrsId { get; set; }

    public int? Grade { get; set; }

    public virtual Course Crs { get; set; } = null!;

    public virtual Student St { get; set; } = null!;
}
