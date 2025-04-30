/*
 * This class is collects the info
 * from adding, modifying, or deleting an answer so it can be put in database
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
    internal class Answer
    {
        public string AnswerText { get; set; } = string.Empty;
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string CorrectValue { get; set; } = string.Empty;
        public DatabaseAction ActionType { get; set; } = DatabaseAction.Add;
        public override string ToString() => AnswerText;
    }
}
