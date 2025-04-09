using System;
using System.Collections.Generic;

namespace StudentQuiz.Models;

public partial class QuizRecord
{
    public int Id { get; set; }

    public int? QuizId { get; set; }

    public int? UserId { get; set; }

    public string? IpAddress { get; set; }

    public DateTime? Submitted { get; set; }

    public int? CorrectAnswers { get; set; }

    public decimal? QuizResults { get; set; }

    public string Status { get; set; } = null!;

    public virtual Quiz? Quiz { get; set; }

    public virtual User? User { get; set; }
}
