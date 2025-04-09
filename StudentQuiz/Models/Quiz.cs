using System;
using System.Collections.Generic;

namespace StudentQuiz.Models;

public partial class Quiz
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string Password { get; set; } = null!;

    public string ValidateAnswers { get; set; } = null!;

    public virtual ICollection<QuizRecord> QuizRecords { get; set; } = new List<QuizRecord>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
