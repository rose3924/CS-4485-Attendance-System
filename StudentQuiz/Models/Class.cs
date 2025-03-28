using System;
using System.Collections.Generic;

namespace StudentQuiz.Models;

public partial class Class
{
    public int Id { get; set; }

    public string? Department { get; set; }

    public string? Number { get; set; }

    public string? Section { get; set; }

    public int? ProfId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public int? SemesterId { get; set; }

    public virtual User? Prof { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual Semester? Semester { get; set; }
}
