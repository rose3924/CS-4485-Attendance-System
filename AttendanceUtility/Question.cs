/*
 * This class is collects the info
 * from new questions being added so it can be put in database
 * 
 * Olivia Anderson
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceUtility
{
    internal class Question
    {
        public string QuestionText { get; set; } = string.Empty;
        public int ClassId { get; set; }
        public int QuestionId { get; set; }
        public int QuizId { get; set; }
        // New property to track the action type
        public DatabaseAction ActionType { get; set; } = DatabaseAction.Add;
        public override string ToString() => QuestionText;
    }
}
