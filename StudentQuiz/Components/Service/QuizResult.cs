
/*
 * 
 * This class is used to store and transfer quiz result data between components.
 * It tracks the number of total quiz questions, the number of correct answers,
 * and the number of incorrect answers for a user's quiz attempt.
 * // Olivia Anderson
 */

namespace StudentQuiz.Components.Service
{
    public class QuizResult
    {
        public int QuizCount { get; set; }
        public int IncorrectAnswers { get; set; }
        public int CorrectAnswers { get; set; }


    }
}
