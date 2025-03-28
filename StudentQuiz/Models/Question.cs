using System;
using System.Collections.Generic;

namespace StudentQuiz.Models;

public partial class Question
{
    public int Id { get; set; }

    public string? QuestionText { get; set; }

    public int? ClassId { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual Class? Class { get; set; }

    public virtual ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();
}
