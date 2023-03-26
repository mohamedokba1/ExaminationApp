using System;
using System.Collections.Generic;

namespace ExaminationApp.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? UserRole { get; set; }

    public string? UserEmail { get; set; }

    public string? UserPassword { get; set; }
}
