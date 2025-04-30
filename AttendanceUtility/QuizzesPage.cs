/*
 * Quizzes Page for Course.
 * Will allow for professor to add questions 
 * and set password for course.
 * 
 * Written by Olivia Anderson (ova210001)
 * 
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
    public partial class QuizzesPage : Form
    {
        // Instance of database object
        private Database dbobject;

        // Professor ID, following succesful login
        private int profId;

        // Course ID, needed to pass to the following forms
        private int courseId;

        // Quiz ID, use to collect questions and answers
        private int quizId;

        // Store information about the Quiz, Questions, and Answers
        private DataTable quizTable = null;  // Quiz data
        private DataTable quizQuestionTable = null; // Quiz-question relationships
        private DataTable questionTable = null;  // Questions
        private DataTable answerTable = null;  // Answers

        // Track if user interaction has started
        private bool userSelectionEnabled = false;

        private BindingSource quizAnswerBindingSource = null;

        private Dictionary<int, Question> modifiedQuestions = null;
        private Dictionary<int, int> newQuestionMapping = null;
        private Dictionary<int, Answer> modifiedAnswers = null;

        // construtor
        public QuizzesPage(Database dbobject, int profId, int courseId)
        {
            InitializeComponent();
            this.dbobject = dbobject;
            this.courseId = courseId;
            this.profId = profId;
            LoadCourseName();

            saveButton.Enabled = false;
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

        /*
         * Button that lets you selct an existing quiz or create a new quiz
        */
        private void NewQuizButton_Click(object sender, EventArgs e)
        {
            LoadQuizPage qpage = new LoadQuizPage(dbobject, profId, courseId);
            qpage.ShowDialog();
            quizId = qpage.QuizId;
            userSelectionEnabled = true;

            // tell you if can find quiz
            if (quizId == 0)
            {
                MessageBox.Show("Unable to find the selected quiz, please try again.");
            }
            else
            {
                LoadDataGridContent();
            }
        }

        /*
         * Load the questions and answers into the DataGridView for each
         * type of item. Place the data loading process in it's own function
         * to facilitate reloading directly from the database.
         */
        private void LoadDataGridContent()
        {
            if (quizId == 0)
            {
                // Thre is nothing to be done if the quizId is zero.
                return;
            }
            // Getting info about quiz
            DataSet quizData = dbobject.GetQuizData(quizId);

            quizTable = quizData.Tables[0]; // Quiz data
            quizQuestionTable = quizData.Tables[1]; // Quiz-question relationships
            questionTable = quizData.Tables[2]; // Questions
            answerTable = quizData.Tables[3]; // Answers

            var filteredQuestions = questionTable.Clone(); // Copy structure

            // I realized later that you could probaly add a filter in the select statement
            foreach (DataRow relRow in quizQuestionTable.Rows)
            {
                if ((int)relRow["quiz_id"] == quizId)
                {
                    var questionId = (int)relRow["question_id"];
                    DataRow[] matchedRows = questionTable.Select($"question_id = {questionId}");
                    foreach (DataRow row in matchedRows)
                    {
                        filteredQuestions.ImportRow(row);
                    }
                }
            }

            // title, password, validate_answers 
            if (quizTable.Rows.Count > 0)
            {
                if (quizTable.Columns.Contains("title"))
                {
                    quiztitleTextBox.Text = quizTable.Rows[0]["title"].ToString();
                }
                if (quizTable.Columns.Contains("password"))
                {
                    passcodeTextBox.Text = quizTable.Rows[0]["password"].ToString();
                }
                if (quizTable.Columns.Contains("validate_answers"))
                {
                    string val = quizTable.Rows[0]["validate_answers"].ToString();
                    if (val != null && val.ToUpper().Equals("T"))
                    {
                        val = "Validate: true";
                    }
                    else
                    {
                        val = "Validate: false";
                    }
                    validateLabel.Text = val;
                }
            }

            // Bind the questions to the DataSource
            BindingSource quizbindingSource = new BindingSource();
            quizbindingSource.DataSource = filteredQuestions;
            questionDataGridView.DataSource = quizbindingSource;
            quizbindingSource.Filter = "";
            questionDataGridView.Columns["question_id"].Visible = false;
            questionDataGridView.Columns["question_text"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            questionDataGridView.Columns["question_text"].HeaderText = "Question";

            answersDataGridView.Columns.Clear();

            // If there are no questions related to the quiz
            // There cannot be any answers

            // NOTE: An empty DataGridView will have 1 row by default,
            //           which is the edit column.
            if (questionDataGridView.Rows.Count == 1)
            {
                // If the current question does not have any answers added default columns.
                // id as answer_id, question_id, answer_text, correct_value 
                answersDataGridView.Columns.Add("answer_id", "answer_id");
                answersDataGridView.Columns.Add("question_id", "question_id");
                answersDataGridView.Columns.Add("answer_text", "Answer");
                answersDataGridView.Columns.Add("correct_value", "Is Correct");

                answersDataGridView.Columns["answer_id"].Visible = false;
                answersDataGridView.Columns["question_id"].Visible = false;
                saveButton.Enabled = false;
                return;
            }

            // Bind the answers to the Table
            DataView view1 = new DataView(answerTable);
            quizAnswerBindingSource = new BindingSource();

            // Limit what can be entered in the "correct_value" column,
            // by intiializing it as a ComboBox.
            DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn();
            comboColumn.DataPropertyName = "correct_value";
            comboColumn.Name = "correct_value";
            comboColumn.HeaderText = "Is Correct";
            comboColumn.Items.Add("T");
            comboColumn.Items.Add("F");

            // Add the column to DataGridView **before** setting the DataSource
            answersDataGridView.Columns.Add(comboColumn);

            quizAnswerBindingSource.DataSource = view1;
            answersDataGridView.DataSource = quizAnswerBindingSource;

            if (answersDataGridView.Columns.Contains("answer_id"))
            {
                answersDataGridView.Columns["answer_id"].Visible = false;
            }
            if (answersDataGridView.Columns.Contains("question_id"))
            {
                answersDataGridView.Columns["question_id"].Visible = false;
            }
            if (answersDataGridView.Columns.Contains("answer_text"))
            {
                answersDataGridView.Columns["answer_text"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            answersDataGridView.Columns["answer_text"].HeaderText = "Answer";

            // Setting the display order of the answer columns
            answersDataGridView.Columns["answer_text"].DisplayIndex = 0;
            answersDataGridView.Columns["correct_value"].DisplayIndex = 1;

            Console.WriteLine("Did a select for the quiz.");

            // The first time the DataGrids are updated, the SelectionChanged
            // event is not called.
            if (questionDataGridView.SelectedRows.Count > 0)
            {
                int selectedQuestionId = Convert.ToInt32(questionDataGridView.SelectedRows[0].Cells["question_id"].Value);
                (quizAnswerBindingSource.DataSource as DataView).RowFilter = $"question_id = {selectedQuestionId} ";
            }

            // If the question table is redrawn, reset the  modifiedQuestions dictionary.
            modifiedQuestions = new Dictionary<int, Question>();
            // Key = temporary question id, Value = new question id
            newQuestionMapping = new Dictionary<int, int>();
            modifiedAnswers = new Dictionary<int, Answer>();
            saveButton.Enabled = false;
        }

        /*
         * When you click on a different quiestion
         * filter the answer so only th ones for that quiestion appear
        */
        private void questionDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (!userSelectionEnabled)
                return; // Ignore the automatic selection

            if (questionDataGridView.SelectedRows.Count > 0 && quizAnswerBindingSource != null)
            {
                object qIdObject = questionDataGridView.SelectedRows[0].Cells["question_id"];
                if (qIdObject == null || ((DataGridViewCell)qIdObject).Value == DBNull.Value)
                {
                    // If the selected row does not have a question_id column, it is a new row.
                    // Without a question_id, there cannot be any answers to display.
                    return;
                }
                int selectedQuestionId = Convert.ToInt32(((DataGridViewCell)qIdObject).Value);
                Console.WriteLine($"User selected question ID: {selectedQuestionId}");

                // Display (filter) only the answers that go with this question.
                // Apply the filter WITHOUT changing DataSource
                BindingSource answerbindingSource = (BindingSource)answersDataGridView.DataSource;
                (answerbindingSource.DataSource as DataView).RowFilter = $"question_id = {selectedQuestionId}";
            }
        }

        /*
         * Give a row index it collects a question id value
         * if new question generatates a tempory index
         * if add new question is negative
        */
        private int GetQuestionId(int rowIndex)
        {
            int question_id = 0;
            if (rowIndex >= 0)
            {
                // Access 'question_id' as an object and then convert the data type.
                object qIdObject = questionDataGridView.Rows[rowIndex].Cells["question_id"];
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

        // In order to handle editing a question, implement the CellValueChanged event 
        // and the UserDeletedRow
        private void questionDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = questionDataGridView.Columns[e.ColumnIndex].Name;

                string newValue = questionDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? string.Empty;

                int question_id = GetQuestionId(e.RowIndex);
                if (question_id < 0)
                {
                    questionDataGridView.Rows[e.RowIndex].Cells["question_id"].Value = question_id; // Assign temporary ID
                }
                DatabaseAction newaction = DatabaseAction.Update;
                if (question_id < 0)
                {
                    newaction = DatabaseAction.Add;
                }
                // Store the modified question
                modifiedQuestions[question_id] = new Question
                {
                    QuestionText = newValue,
                    ClassId = courseId,
                    QuizId = quizId,
                    QuestionId = question_id,
                    ActionType = newaction
                };
                saveButton.Enabled = true;
            }
        }
        
    }
}
