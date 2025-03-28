using System;
using System.Collections.Generic;

namespace StudentQuiz.Models;

public partial class Enrollment
{
    public int? UserId { get; set; }

    public int? ClassId { get; set; }

    public virtual Class? Class { get; set; }

    public virtual User? User { get; set; }
}
