using System;
using System.Collections.Generic;

namespace ExaminationApp.Models;

public partial class Topic
{
    public int TopicId { get; set; }

    public string? TopicName { get; set; }

    public virtual ICollection<Course> Courses { get; } = new List<Course>();
}
