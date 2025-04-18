using System;
using System.Collections.Generic;

namespace StudentQuiz.Models;

public partial class DaysOfWeek
{
    public int Id { get; set; }

    public string? Day { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
