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

                    // Create a new radio button
                    RadioButton radio = new RadioButton();
                    radio.Text = semestersDescription;
                    radio.Location = new System.Drawing.Point(15, y);
                    radio.AutoSize = true;

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
         * Empty submit button method
         */
        private void SubmitButton_Click(object sender, EventArgs e)
        {
           // dbobject.CreateClass();
            
        }
    }
}
