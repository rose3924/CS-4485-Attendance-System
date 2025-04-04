/*
 * Individual Class Page for the Courses taught by the currently active Professor user.
 * Displays options for: Attendance, Quizzes and Passwords.
 * 
 * Not functional to go to other pages
 * 
 * Written by Cristina Adame (caa220007)
 * starting March 28, 2025
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceUtility
{
    public partial class ClassPage : Form
    {
        // Instance of database object
        private Database dbobject;

        // Course ID, needed to pass to the following forms
        private int courseId;

        public ClassPage(Database dbobject, int courseId)
        {
            InitializeComponent();
            this.dbobject = dbobject;
            this.courseId = courseId;
            
            LoadCourseName();
        }
        
        public void LoadCourseName()
        {
            DataTable courseDetails = dbobject.GetCourseDetails(courseId);

            // First/Only row in the table
            DataRow row = courseDetails.Rows[0];

            //Name comprised of department, course number and course section, ex CS 1334.004
            string courseName = $"{row["department"]}{row["number"]}.{row["section"]}";
            
            CourseLabel.Text = courseName;
        }

        /*
         * Closes the current form and creates a new login screen
         */
        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            // Close the current form and show the login form
            this.Close();
            new LoginScreen(dbobject).Show();
        }
    }
}
