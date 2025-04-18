/*
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filterCSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CSVButton_Click(object sender, EventArgs e)
        {
            userFilepath.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void userFilepath_TextChanged(object sender, EventArgs e)
        {

        }

        private void userFilepath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Optional: prevents ding sound
                filePath = userFilepath.Text;
                userFilepath.Visible = false;

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
                //file open dialogue
            }
        }

        private void AttendanceDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
