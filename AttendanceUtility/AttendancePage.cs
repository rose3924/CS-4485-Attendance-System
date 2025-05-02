/*
 * AttendancePage.cs
 * 
 * Attendance Page for Course
 * Will allow for a csv file to be uploaded into 
 * 
 * Written by Cristina Adame (caa220007)
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


        public AttendancePage(Database dbobject, int profId, int courseId)
        {
            InitializeComponent();
            this.dbobject = dbobject;
            this.courseId = courseId;
            this.profId = profId;
            LoadCourseName();
            label1.Text = monthCalendar1.SelectionStart.ToString("MMMM dd, yyyy");
            attendecneDataGrid.DataSource = dbobject.getStudentQuizzesForDay(monthCalendar1.SelectionStart.Date);
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

        private void CSVButton_Click(object sender, EventArgs e)
        {
            /*    OpenFileDialog openCSV = new OpenFileDialog();
                //openCSV.Filter = "Text files| *.txt | All files | *.*";
                if (openCSV.ShowDialog() == DialogResult.OK)
                {
                    filePath = openCSV.FileName;
                    string[] data = File.ReadAllLines(filePath);
                    string[] fields;
                    fields = data[0].Split(new char[] { '\t' });
                    int col = fields.GetLength(0);
                    DataTable csvTable = new DataTable();
                    for (int i = 0; i < col; i++)
                    {
                        csvTable.Columns.Add(fields[i].ToLower(), typeof(String));

                    }
                    DataRow row;
                    for (int i = 1; i < data.GetLength(0); i++)
                    {
                        fields = data[i].Split(new char[] { '\t' });
                        row = csvTable.NewRow();
                        for (int x = 0; x < col; x++)
                        {
                            row[x] = fields[x];
                        }
                        csvTable.Rows.Add(row);
                    }
                    AttendanceDataGrid.DataSource = csvTable;
                    dbobject.insertAttendenceRec(csvTable);
                }*/
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
        private void timer()
        {
            date = new System.Windows.Forms.Timer();
            date.Interval = 1000;
            date.Tick += new EventHandler(currentDate_Tick);
            date.Enabled = true;
            label1.Text = DateOnly.FromDateTime(DateTime.Now).ToString("MMMM dd, yyyy");
            //attendecneDataGrid.DataSource = dbobject.getStudentQuizzesForDay(DateOnly.FromDateTime(DateTime.Now));

        }
        private void currentDate_Tick(object sender, EventArgs e)
        {
            date = new System.Windows.Forms.Timer();
            attendecneDataGrid.DataSource = dbobject.getStudentQuizzesForDay(monthCalendar1.SelectionStart.Date);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            label1.Text = monthCalendar1.SelectionStart.ToString("MMMM dd, yyyy");
            attendecneDataGrid.DataSource = dbobject.getStudentQuizzesForDay(monthCalendar1.SelectionStart.Date);
        }

        private void TodayButton_Click(object sender, EventArgs e)
        {
            timer();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = monthCalendar1.SelectionStart.AddDays(-1);
            label1.Text = monthCalendar1.SelectionStart.ToString("MMMM dd, yyyy");
            attendecneDataGrid.DataSource = dbobject.getStudentQuizzesForDay(monthCalendar1.SelectionStart.Date);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = monthCalendar1.SelectionStart.AddDays(1);
            label1.Text = monthCalendar1.SelectionStart.ToString("MMMM dd, yyyy");
            attendecneDataGrid.DataSource = dbobject.getStudentQuizzesForDay(monthCalendar1.SelectionStart.Date);
        }
        private void changeDate()
        {
        }

        private void attendecneDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (attendecneDataGrid.Columns[e.ColumnIndex].Name == "attendance")
            {
                var row = attendecneDataGrid.Rows[e.RowIndex];
                string cellChanged = row.Cells["attendance"].Value?.ToString();
                if (cellChanged == "Present")
                {
                    string sid = row.Cells["student_id"].Value.ToString();
                    DateTime day = monthCalendar1.SelectionRange.Start.Date;

                    DialogResult confirmation = MessageBox.Show(
                        "Confirming will change " + row.Cells["firstname"].Value.ToString() + " " + row.Cells["lastname"].Value.ToString() + " to " + row.Cells["attendance"].Value.ToString(),
                        "Confirm Change",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirmation == DialogResult.Yes)
                    {
                        dbobject.changeAttendenceRecord(sid, day);

                    }
                    else
                    {


                    }


                }
                else 
                {
                    MessageBox.Show("Please enter valid attendance status: Present, Absent, or Late", "Invalid Attendance Status",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    } }
