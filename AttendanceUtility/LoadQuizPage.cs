/*
 * A page that lets the user craete a new quiz
 * The user can either choose an existing quiz or they can create a new quiz
 * 
 * Written by Olivia Anderson (ova210001)
 * Started 4/20/2025
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
    public partial class LoadQuizPage : Form
    {
        // Instance of database object
        private Database dbobject;

        // Professor ID, following succesful login
        private int profId;

        // Course ID, needed to pass to the following forms
        private int courseId;

        // Quiz ID, if the user selects to view an existing quiz
        // or if the user selects to create a new one.
        private int quizId = 0;

        // constructor 
        public LoadQuizPage(Database dbobject, int profId, int courseId)
        {
            InitializeComponent();
            this.dbobject = dbobject;
            this.courseId = courseId;
            this.profId = profId;
            LoadCourseName();

            // Controls for a new quiz
            // Make these the default
            setNewQuizControl(true);

            // Load existing quiz
            quizComboBox.Enabled = false;
        }

        // Property that lets form get selected quiz id from the form
        public int QuizId
        {
            get { return quizId; }
            set { quizId = value; }
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

        // a cancel button
        // means that person doesn't want to do anything with the quiz id so close box and do nothing
        private void cancelButton_Click(object sender, EventArgs e)
        {
            QuizId = -1;
            this.Close();
        }

        // toggles the controls for a new quiz when clicking the action box
        private void setNewQuizControl(bool value)
        {
            // Controls for a new quiz
            // Make these the default
            titleLabel.Enabled = value;
            titleTextBox.Enabled = value;
            passcodeLabel.Enabled = value;
            passcodeTextBox.Enabled = value;
            validateCheckBox.Enabled = value;

        }

        // a radio button
        // it sets the form charateristics depending on what user picks
        // this on works for both load and new becuase it is a toggle
        private void newRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (newRadioButton.Checked)
            {
                setNewQuizControl(true);
                quizComboBox.Enabled = false;
            }
            else
            {
                DataTable quizzes = dbobject.GetCourseQuizzes(courseId);


                // The user is trying to view an existing quiz, but
                // the query didn't find any. This means the only option
                // is to create a new quiz.
                if (quizzes.Rows.Count == 0)
                {
                    StringBuilder strbuilder = new StringBuilder();
                    strbuilder.Append("Unable to find any existing quizzes for the class titled: ");
                    strbuilder.Append(CourseLabel.Text);
                    strbuilder.Append(". The only option is to add a new quiz.");
                    messageTextBox.Text = strbuilder.ToString();

                    // Check the other check box.
                    newRadioButton.Checked = true;
                    return;
                }

                setNewQuizControl(false);
                quizComboBox.Enabled = true;

                //populte drop down box
                quizComboBox.Items.Clear();
                foreach (DataRow row in quizzes.Rows)
                {
                    quizComboBox.Items.Add(new ComboBoxItem
                    {
                        Text = row["title"].ToString(),
                        Value = (int)row["id"]
                    });
                }

                // select first item in list by default
                if (quizComboBox.Items.Count > 0)
                {
                    quizComboBox.SelectedItem = 0;
                }
            }
        }

        // a submit button
        // will perfrom the action selected in the action box
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (newRadioButton.Checked)
            {
                string errormessage = string.Empty;

                /// if have values
                if (newQuizValuesExist(ref errormessage) == false)
                {
                    messageTextBox.Text = errormessage;
                    return;
                }

                QuizId = dbobject.CreateNewQuiz(titleTextBox.Text, passcodeTextBox.Text, validateCheckBox.Checked, courseId);
            }
            else
            {
                ComboBoxItem item = (ComboBoxItem)quizComboBox.Items[quizComboBox.SelectedIndex];

                if (item != null)
                {
                    QuizId = item.Value;
                }
            }
            this.Close();
        }

        // a function that verifies that the user has entered values
        private bool newQuizValuesExist(ref string errormessage)
        {
            // assuming everthing is true unless proven otherwise
            bool isvalid = true;

            if (titleTextBox.Text.Equals(""))
            {
                errormessage = "The title field cannot be empty. "+Environment.NewLine;
                isvalid = false;
            }
            if (passcodeTextBox.Text.Equals(""))
            {
                errormessage = errormessage + "The passcode field cannot be empty. " + Environment.NewLine;
                isvalid = false;
            }

            return isvalid;
        }
    }
}
