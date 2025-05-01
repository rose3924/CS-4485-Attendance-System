/*
 * A page that lets the professor select existing question to add to a quiz
 * 
 * Written by Olivia Anderson
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
    public partial class QuestionsPage : Form
    {
        // Instance of database object
        private Database dbobject;

        // Professor ID, following succesful login
        private int profId;

        // Course ID, needed to pass to the following forms
        private int courseId;

        private List<int> selids = new List<int>();
        public QuestionsPage(Database dbobject, int profId, int courseId)
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
        * Back Button
        * Closes the current form and creates a ClassPage form
        */
        private void BackButtonBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<int> SelectedQuestionIds
        {
            get { return selids; }
            set { selids = value; }
        }

        /*
         * Load the questions and answers into the DataGridView for each
         * type of item. Place the data loading process in it's own function
         * to facilitate reloading directly from the database.
         */
        private void LoadDataGridContent()
        {
            DataTable questionData = dbobject.GetQuestions(courseId);

            // Bind the questions to the DataSource
            BindingSource questionBindingSource = new BindingSource();
            questionBindingSource.DataSource = questionData;
            QuestionsDataGrid.DataSource = questionBindingSource;

            QuestionsDataGrid.Columns["question_id"].Visible = false;
            QuestionsDataGrid.Columns["question_text"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QuestionsDataGrid.Columns["question_text"].HeaderText = "Question";
        }

        // This DataGridView does not allow editing so there should always 
        private int GetQuestionId(int rowIndex)
        {
            int question_id = 0;
            if (rowIndex >= 0)
            {
                // Access 'question_id' as an object and then convert the data type.
                object qIdObject = QuestionsDataGrid.Rows[rowIndex].Cells["question_id"];
                DataGridViewCell qIdGridViewCell = (DataGridViewCell)qIdObject;
                object questionIdValue = qIdGridViewCell.Value;

                // If the row is new (missing an ID), assign a temporary one
                if (questionIdValue == null || questionIdValue == DBNull.Value || string.IsNullOrEmpty(questionIdValue.ToString()))
                {
                    question_id = -1 * (rowIndex + 1);  // Use a negative ID based on row index
                }
                else
                {
                    question_id = Convert.ToInt32(questionIdValue); // Use existing ID
                }
            }
            return question_id;
        }
        private List<int> GetSelectedQuestionIds()
        {
            List<int> selectedQuestions = new List<int>();

            foreach (DataGridViewRow row in QuestionsDataGrid.SelectedRows)
            {
                if (row.Cells["question_id"].Value != null && row.Cells["question_id"].Value != DBNull.Value)
                {
                    int questionId = Convert.ToInt32(row.Cells["question_id"].Value);
                    selectedQuestions.Add(questionId);
                }
            }

            return selectedQuestions;
        }

        private void selectQuestionButton_Click(object sender, EventArgs e)
        {
            selids = GetSelectedQuestionIds();
            this.Close();
        }

        private void QuestionsPage_Load(object sender, EventArgs e)
        {
            LoadDataGridContent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
