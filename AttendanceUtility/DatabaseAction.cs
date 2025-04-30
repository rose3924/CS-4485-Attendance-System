/*
 * This helps keep track of what databse action is being taken
 * lets use type words instead of having to type numbers
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
    internal enum DatabaseAction
    {
        Add,    // Represents a new question
        Update, // Represents a modified question
        Delete  // Represents a removed question
    }
}
