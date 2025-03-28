using System;
using System.Collections.Generic;

namespace StudentQuiz.Models;

public partial class Answer
{
    public int Id { get; set; }

    public int QuestionId { get; set; }

    public string AnswerText { get; set; } = null!;

    public string CorrectValue { get; set; } = null!;

    public virtual Question Question { get; set; } = null!;
}
