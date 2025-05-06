/*
 * AttendancePage.cs
 * 
 * Attendance Page for Course
 * Will allow for a csv file to be uploaded into 
 * 
 * Written by Cristina Adame (caa220007) and Angelica Bell
 * starting April , 2025
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceUtility
{
    public partial class AttendancePage : Form
    {
        private string filePath;
        // Instance of database object
        private Database dbobject;

        // Professor ID, following succesful login
        private int profId;

        // Course ID, needed to pass to the following forms
        private int courseId;

        //
        public AttendancePage(Database dbobject, int profId, int courseId)
        {
            InitializeComponent();
            this.dbobject = dbobject;
            this.courseId = courseId;
            this.profId = profId;
            LoadCourseName();
            //sets label to the current date
            dateLabel.Text = monthCalendar1.SelectionStart.ToString("MMMM dd, yyyy");
            //pulls quizzes for current day from database and displays attendance information
            attendecneDataGrid.DataSource = dbobject.getStudentQuizzesForDay(monthCalendar1.SelectionStart.Date);
            dataGridDropDow();
            //making attendance  column editable so user can change attendance status 
            attendecneDataGrid.Columns["attendance"].ReadOnly = false;
            //timer();
        }

        /*
         * Adds name of current course to header
         * Cristina Adame
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
         * Cristina Adame
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
        * Cristina Adame
        */
        private void BackButtonBox_Click(object sender, EventArgs e)
        {
            this.Close();
            new ClassPage(dbobject, profId, courseId).Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filterCSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            new csv(dbobject).Show();
        }

        private void userFilepath_TextChanged(object sender, EventArgs e)
        {

        }



        private void AttendanceDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        System.Windows.Forms.Timer date = null;
        //tracks current date and time
        private void timer()
        {
            date = new System.Windows.Forms.Timer();
            date.Interval = 1000;
            date.Tick += new EventHandler(currentDate_Tick);
            date.Enabled = true;
            dateLabel.Text = DateOnly.FromDateTime(DateTime.Now).ToString("MMMM dd, yyyy");
            monthCalendar1.SelectionStart = DateTime.Now;
            //attendecneDataGrid.DataSource = dbobject.getStudentQuizzesForDay(DateOnly.FromDateTime(DateTime.Now));

        }
        //shows quizzes from current day if 'today button' is clicked 
        private void currentDate_Tick(object sender, EventArgs e)
        {
            date = new System.Windows.Forms.Timer();
            attendecneDataGrid.DataSource = dbobject.getStudentQuizzesForDay(monthCalendar1.SelectionStart.Date);
            dataGridDropDow();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //displays attendance infromation for
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateLabel.Text = monthCalendar1.SelectionStart.ToString("MMMM dd, yyyy");

            attendecneDataGrid.DataSource = dbobject.getStudentQuizzesForDay(monthCalendar1.SelectionStart.Date);
            dataGridDropDow();
        }

        private void TodayButton_Click(object sender, EventArgs e)
        {
            timer();
        }

        private void changeDate()
        {
        }
        //user change attendance status in database by changing data in dropdown 
        private void attendecneDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (attendecneDataGrid.Columns[e.ColumnIndex].Name == "attendance")
            {
                var row = attendecneDataGrid.Rows[e.RowIndex];
                string cellChanged = row.Cells["attendance"].Value?.ToString();
                //if (cellChanged == "Present")
                //{
                string sid = row.Cells["student_id"].Value.ToString();
                DateTime day = monthCalendar1.SelectionRange.Start.Date;
                //asking user for confirmation
                DialogResult confirmation = MessageBox.Show(
                    "Confirming will change " + row.Cells["firstname"].Value.ToString() + " " + row.Cells["lastname"].Value.ToString() + " to " + row.Cells["attendance"].Value.ToString(),
                    "Confirm Change",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    dbobject.changeAttendenceRecord(sid, day, row.Cells["attendance"].Value.ToString());

                }
                else
                {


                }


            }
        }
        //drap down defintion of dropdown that allows user to change attendance information 
        private void dataGridDropDow()
        {
            string col = "attendance";
            DataGridViewComboBoxColumn dropDowCol = new DataGridViewComboBoxColumn();
            dropDowCol.Name = col;
            dropDowCol.HeaderText = "attendance";
            dropDowCol.DataPropertyName = col;
            dropDowCol.Items.AddRange("Present", "Absent");

            int index = attendecneDataGrid.Columns[col].Index;
            attendecneDataGrid.Columns.RemoveAt(index);
            attendecneDataGrid.Columns.Insert(index, dropDowCol);
        }

   
        // private List<status> get
        private void AttendancePage_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {
            new csv(dbobject).Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            new filterReport(dbobject, courseId).Show();

        }
        //add one to selected date and get attendance data for that day
        private void incrementDate_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = monthCalendar1.SelectionStart.AddDays(1);
            dateLabel.Text = monthCalendar1.SelectionStart.ToString("MMMM dd, yyyy");
            attendecneDataGrid.DataSource = dbobject.getStudentQuizzesForDay(monthCalendar1.SelectionStart.Date);
            dataGridDropDow();
        }
        //subtrack one to selected date and get attendance data for that day
        private void decrementDate_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = monthCalendar1.SelectionStart.AddDays(-1);
            dateLabel.Text = monthCalendar1.SelectionStart.ToString("MMMM dd, yyyy");
            attendecneDataGrid.DataSource = dbobject.getStudentQuizzesForDay(monthCalendar1.SelectionStart.Date);
            dataGridDropDow();
        }
    }
}
