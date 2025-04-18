/*
 * Quizzes Page for Course.
 * Will allow for professor to add questions 
 * and set password for course.
 * 
 * Written by Cristina Adame (caa220007)
 * starting April XX, 2025
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
    public partial class QuizzesPage: Form
    {
        // Instance of database object
        private Database dbobject;

        // Professor ID, following succesful login
        private int profId;

        // Course ID, needed to pass to the following forms
        private int courseId;
        public QuizzesPage(Database dbobject, int profId, int courseId)
        {
            InitializeComponent();
            this.dbobject = dbobject;
            this.courseId = courseId;
            this.profId = profId;
            LoadCourseName();
        }

        /*
         * Adds name of current course to header
         */
        public void LoadCourseName()
        {
            DataTable courseDetails = dbobject.GetCourseDetails(courseId);

            // First/Only row in the table
            DataRow row = courseDetails.Rows[0];

            //Name comprised of department, course number and course section, ex CS 1334.004
            string courseName = $"{row["department"]}{row["number"]}.{row["section"]} {row["name"]}";

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

        /*
        * Back Button
        * Closes the current form and creates a ClassPage form
        */
        private void BackButtonBox_Click(object sender, EventArgs e)
        {
            this.Close();
            new ClassPage(dbobject, profId, courseId).Show();
        }
    }
}
