/*
 * ClassesHomePage.cs
 * 
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
        private int profId;

        // Course ID, needed to pass to the ClassPage form
        private int courseId;

        // Constructor takes instance of database
        public ClassesHomePage(Database dbobject, int profId)
        {
            InitializeComponent();
            this.dbobject = dbobject;
            this.profId = profId;

            // Load the professor's name
            LoadProfName();

            // Load the initial classes for the professor
            LoadInitialProfClasses();
        }

        /*
         * Adds name of current professor to header
         */
        private void LoadProfName()
        {
            // Get the professor's name from the database
            DataTable profDetails = dbobject.GetProfessorName(profId);
            // First/Only row in the table
            DataRow row = profDetails.Rows[0];
            // Set the label text to the professor's name
            ProfNameLabel.Text = $"Welcome, Professor {row["firstname"]} {row["lastname"]}";
        }

        /*
         * Loads the semester drop down option and displays the first semester courses
         */
        public void LoadInitialProfClasses()
        {
            //Loads the semesters to the combo box
            LoadSemesterComboBox();

            // If there are semesters, select the first one and load the classes for that semester
            if (SemesterComboBox.Items.Count > 0)
            {
                SemesterComboBox.SelectedIndex = 0;
                LoadSelectedSemesterProfClasses((int)SemesterComboBox.SelectedValue);
            }
        }

        /*
         * Loads the classes for the selected semester.
         * Clears the layout panel and dynamically creates buttons based on number of course the Professor teaches.
         * Creates DataTable, for each row displays a button.
         */
        private void LoadSelectedSemesterProfClasses(int semesterId)
        {
            DataTable profClasses = dbobject.GetProfessorSemesterClasses(profId, semesterId);
            // Clear the layout panel before adding new buttons 
            ClassesHomeLayoutPanel.Controls.Clear();

            foreach (DataRow row in profClasses.Rows)
            {
                // Get class days
                List<string> days = dbobject.GetClassDays((int)row["id"]);
                string daysString = string.Join(", ", days);


                // Details of the construction of the buttons (text, tag, dimensions)
                Button CourseButton = new Button
                {
                    // Displays for example: 'CS 1337.002' on button with time of class hh:mm tt so 10:23 AM
                    Text = $"{row["department"]}{row["number"]}.{row["section"]} - {row["name"]}" +
                            $"\n{row["description"]} Credit Hours" +
                            $"\nTime: {DateTime.Today.Add((TimeSpan)row["start_time"]).ToString("hh:mm tt")} - {DateTime.Today.Add((TimeSpan)row["end_time"]).ToString("hh:mm tt")}" +
                            $"\nDays: " + daysString,


                    // Tag stores the course id, to be retrieved later and passed to ClassPage
                    Tag = row["id"],
                    Width = 887,
                    Height = 134,
                    Margin = new Padding((ClassesHomeLayoutPanel.Width - 887) / 2, 10, 0, 10), // Center the buttons
                    Anchor = AnchorStyles.None

                };

                // Adds the method of clicking the button to the newly created button
                CourseButton.Click += CourseButton_Click;

                // Adds the new button to the form layout panel
                ClassesHomeLayoutPanel.Controls.Add(CourseButton);
            }

            // Add space at the bottom so the scrolling doesn't cut off a class
            Panel spacerPanel = new Panel
            {
                Height = 70,
                Dock = DockStyle.Bottom
            };

            // Adds the new spacer panel to the form layout panel
            ClassesHomeLayoutPanel.Controls.Add(spacerPanel);

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
                new ClassPage(dbobject, profId, courseId).Show();
            }
        }

        /*
         * Dynamically adds the semesters to a drop down selection box combo for filtering.
         */
        private void LoadSemesterComboBox()
        {
            // Get the list of semesters the professor teaches from the database
            DataTable semesters = dbobject.GetProfessorSemesters(profId);

            if (semesters.Rows.Count == 0)
            {
                // If no semesters are found, show no classes message and return
                NoCoursesMessageLabel.Visible = true;
                SemesterComboBox.Visible = false;
            }
            else
            {
                // If semesters are found, hide the message
                NoCoursesMessageLabel.Visible = false;


                // Load the description and store the value for the semesters
                SemesterComboBox.DisplayMember = "description";
                SemesterComboBox.ValueMember = "id";
                SemesterComboBox.DataSource = semesters;
            }
        }

        // Method to call semesters from combo box selection
        private void SemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Retrieve and store the semesterId
            int semesterId = (int)SemesterComboBox.SelectedValue;

            // Load courses based on selected semester
            LoadSelectedSemesterProfClasses(semesterId);

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
         * Adds form to create a new class and add it to the database
         */
        private void AddClassButton_Click(object sender, EventArgs e)
        {
            new CreateClassForm(dbobject, profId, this).ShowDialog();
        }
        
    }
}
