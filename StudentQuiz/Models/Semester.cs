using System;
using System.Collections.Generic;

namespace StudentQuiz.Models;

public partial class Semester
{
    public int Id { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
