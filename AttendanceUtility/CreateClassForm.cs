/* CreateClassForm.cs
 * 
 * ---description here ---
 * Form to create a class and add to the database.
 * 
 * Written by Cristina Adame (caa220007)
 * starting April XX, 2025???
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
    public partial class CreateClassForm : Form
    {
        // Instance of database object
        private Database dbobject;

        // Professor ID, following succesful login
        private int profId;

        // Course ID, needed to pass to the ClassPage form
        private int courseId;

        // Constructor takes instance of database
        public CreateClassForm(Database dbobject, int profId)
        {
            InitializeComponent();
            this.dbobject = dbobject;
            this.profId = profId;

            // Load the semesters for selection
            LoadSemesterGroupBox();
        }

        /*
         * Loads all semesters from the database into the group box for selection when creating a class
         */
        private void LoadSemesterGroupBox()
        {
            try
            {
                // Get semesters from the database
                DataTable semestersTable = dbobject.GetSemesters();

                int y = 30;

                foreach (DataRow row in semestersTable.Rows)
                {
                    string semestersDescription = row["description"].ToString();
                    int semesterId = Convert.ToInt32(row["id"]);

                    // Create a new radio button
                    RadioButton radio = new RadioButton();
                    radio.Text = semestersDescription;
                    radio.Location = new System.Drawing.Point(15, y);
                    radio.AutoSize = true;
                    radio.Tag = semesterId;

                    // Add the semester to the group box
                    SemesterGroupBox.Controls.Add(radio);

                    // Add space for next radio button
                    y += 40;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No semesters to load" + ex.Message);
            }

        }

        /*
         * Closes the current form due to user cancelation
         */
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * Submit button click event handler
         * Ensures all values are filled out and adds class to the database
         */
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values from the form
                string department = DepartmentTextBox.Text.Trim().ToUpper();
                string number = NumberTextBox.Text;
                string section = SectionTextBox.Text;
                TimeSpan startTime = StartTimePicker.Value.TimeOfDay;
                TimeSpan endTime = EndTimePicker.Value.TimeOfDay;
                string name = NameTextBox.Text.Trim();
                string description = CreditHoursTextBox.Text.Trim();
                int semester = GetSelectedSemesterId();
                List<int> selectedDays = GetSelectedDays();


                // Check if all fields are filled
                if (department == "" || number == "" || section == "" || startTime == null || endTime == null || name == "" || description == "" || semester == -1 || selectedDays.Count == 0 )
                {
                    MessageBox.Show("Please fill in all fields." + semester);
                    return;
                }
                int creditHours = int.Parse(description);

                // Call the method to create a class in the database
                int classId = dbobject.CreateClass(profId, department, number, section, startTime, endTime, name, creditHours, semester);
                
                foreach (int day in selectedDays)
                {
                    // Add each selected day to the class
                    dbobject.AddClassDays(classId, day);
                }

                this.Close();

                // Display success message with class name
                MessageBox.Show("Class: \"" + department + " " + number + "." + section + " " + name + "\" was succesfully added");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating class: " + ex.Message);
            }
        }

        /*
         * Gets the selected semester ID from the radio buttons in the group box
         * Returns the ID of the selected semester, or -1 if none is selected
         */
        private int GetSelectedSemesterId()
        {
            foreach (var control in SemesterGroupBox.Controls)
            {
                RadioButton rb = control as RadioButton;
                if (rb != null && rb.Checked)
                {
                    return (int)rb.Tag;
                }
            }
            return -1;
        }

        /*
         * Gets the selected days from the checkboxes in the group box
         * Returns a list of integers representing the selected days, respective to database representation
         */
        private List<int> GetSelectedDays()
        {
            List<int> selectedDayIds = new List<int>();

            foreach (CheckBox checkBox in DaysGroupBox.Controls)
            {
                if (checkBox is CheckBox && checkBox.Checked)
                {
                    string text = checkBox.Text;

                    // Map the checkbox text to the corresponding day ID ex. M = 1, T = 2, W = 3, Th = 4, F = 5
                    if (text == "M")
                        selectedDayIds.Add(1);
                    else if (text == "T")
                        selectedDayIds.Add(2);
                    else if (text == "W")
                        selectedDayIds.Add(3);
                    else if (text == "Th")
                        selectedDayIds.Add(4);
                    else if (text == "F")
                        selectedDayIds.Add(5);
                }
            }

            return selectedDayIds;
        }

    }
}
