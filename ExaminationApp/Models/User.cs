using System;
using System.Collections.Generic;

namespace ExaminationApp.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserRole { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public string UserPassword { get; set; } = null!;
}
