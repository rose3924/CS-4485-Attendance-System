using System;
using System.Collections.Generic;

namespace StudentQuiz.Models;

public partial class User
{
    public int Id { get; set; }

    public string? LoginId { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? StudentId { get; set; }

    public string? Passcode { get; set; }

    public string UserRole { get; set; } = null!;

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();

    public virtual ICollection<QuizRecord> QuizRecords { get; set; } = new List<QuizRecord>();
}
