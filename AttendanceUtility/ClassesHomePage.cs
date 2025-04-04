/*
 * Home Page for Professors following their successful login.
 * Displays their classes as buttons to select in order to see further details.
 * Contains a functional logout button.
 * 
 * Written by Cristina Adame (caa220007)
 * starting March 28, 2025
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceUtility
{
    public partial class ClassesHomePage : Form
    {
        // Instance of database object
        private Database dbobject;

        // Professor ID, following succesful login
        private int prof_id = 3;

        // Course ID, needed to pass to the ClassPage form
        private int course_id;

        // Constructor takes instance of database
        public ClassesHomePage(Database dbobject)
        {
            InitializeComponent();
            this.dbobject = dbobject;
            LoadProfClasses();
        }

        /*
         * Dynamically creates buttons based on number of course the Professor teaches.
         * Creates DataTable, for each row displays a button.
         */
        private void LoadProfClasses()
        {
            DataTable profClasses = dbobject.GetProfessorClasses(prof_id);

            //Clears the layout panel of any residual buttons
            ClassesHomeLayoutPanel.Controls.Clear();

            foreach (DataRow row in profClasses.Rows)
            {
                // Details of the construction of the buttons (text, tag, dimensions)
                Button CourseButton = new Button
                {
                    // Displays for example: 'CS 1337.002' on button with time of class hh:mm tt so 10:23 AM
                    Text = $"{row["department"]}{row["number"]}.{row["section"]}" +
                    $"\n Time: {Convert.ToDateTime(row["start_time"]).ToString("hh:mm tt")} - {Convert.ToDateTime(row["end_time"]).ToString("hh:mm tt")}",

                    // Tag stores the course id, to be retrieved later and passed to ClassPage
                    Tag = row["id"],
                    Width = 887,
                    Height = 134

                };

                // Adds the method of clicking the button to the newly created button
                CourseButton.Click += CourseButton_Click;

                // Adds the new button to the form layout panel
                ClassesHomeLayoutPanel.Controls.Add(CourseButton);
            }

        }

        /*
         * Clicking on a course will close the current page and open the individual course page.
         * Passes the database instance and the course_id of the selected course.
         */
        private void CourseButton_Click(object sender, EventArgs e)
        {
            // Button instance of pressed button
            Button pressedButton = sender as Button;
            
            // When a button is pressed, gathers data of Button + Action
            if (pressedButton != null)
            {
                // Get courseId stored in the button's Tag
                int courseId = (int)pressedButton.Tag;

                this.Close();
                new ClassPage(dbobject, courseId).Show();
            }
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
