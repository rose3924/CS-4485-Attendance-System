/* Database.cs
 * 
 * ---description here ---
 * Contains methods to retrieve information from the connected database.
 *      Student Data
 *      Professor Courses Data
 *      Course Details Data
 *      Semester Details Data
 * 
 * Written by Olivia Anderson (ova210001) and Cristina Adame (caa220007)
 * starting March XX, 2025???
 */
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AttendanceUtility
{
    public class Database
    {
        private string db_server = "";
        private string database_name = "";
        private string db_user = "";
        string db_pwd = "";

        // Giving constructor parameters needed to intiate databse connection
        // Olivia Anderson
        public Database(string server, string name, string uname, string encrypted_pwd)
        {
            db_server = server;
            database_name = name;
            db_user = uname;

            db_pwd = encrypted_pwd;
        }

        // establish connection to Azure database
        // Olivia Anderson
        protected SqlConnection GetAzureMySQLConnection()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = db_server,
                UserID = db_user,
                Password = db_pwd,
                InitialCatalog = database_name
            };
            var connectionString = builder.ConnectionString;
            return new SqlConnection(connectionString);
        }

        // ------------------------------------------------------------------
        // funtions that return info 

        // returns students as data table
        // this was an usage example
        // Olivia Anderson
        public DataTable GetStudents()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    var sql = "SELECT login_id, firstname, lastname, student_id FROM users where user_role = 'STUDENT' ";
                    using (var dataAdapter = new SqlDataAdapter(sql, connection))
                    {
                        connection.Open();
                        dataAdapter.Fill(dataTable);

                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\nQuery finished for Users.");
            return dataTable;
        }

        /*
         * Gathers information of the courses taught by a Professor given the professorId.
         * Creates/Returns a data table with the course id, department name, course number, course section,
         * professor id, start time, end time, and semester.
         * Cristina Adame
         */
        public DataTable GetProfessorClasses(int professorId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    // Query for table, specific to the class table in the database
                    string profQuery = @"SELECT id, department, number, section, prof_id, start_time, end_time, semester_id, name, description FROM class WHERE prof_id = @professorId";

                    using (SqlCommand command = new SqlCommand(profQuery, connection))
                    {
                        // Adds the input professor id to the professorId
                        command.Parameters.Add("@professorId", SqlDbType.Int).Value = professorId;

                        using (var dataAdapter = new SqlDataAdapter(command))
                        {
                            connection.Open();
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return dataTable;
        }
        /*
         * Gathers information of the professor given the professorId.
         * Creates/Returns a data table with the first name and last name of the professor.
         * Cristina Adame
        */
        public DataTable GetProfessorName(int professorId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    // Query for table, specific to get semesters the professor teaches
                    string profNameQuery = @"SELECT firstname, lastname 
                                        FROM users 
                                        WHERE id = @profId";

                    using (SqlCommand command = new SqlCommand(profNameQuery, connection))
                    {
                        // Adds the input professor id to the profId
                        command.Parameters.Add("@profId", SqlDbType.Int).Value = professorId;

                        using (var dataAdapter = new SqlDataAdapter(command))
                        {
                            connection.Open();
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return dataTable;
        }

        /*
         * Gathers information of the course taught given course id
         * Creates/Returns a data table with the course id, department name, course number, course section,
         * professor id, start time, end time, and semester.
         * Cristina Adame
         */
        public DataTable GetCourseDetails(int classId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    // Query for table, specific to the class table in the database
                    string classQuery = @"SELECT id, department, number, section, prof_id, start_time, end_time, semester_id, name FROM class WHERE id = @classId";
                    using (SqlCommand command = new SqlCommand(classQuery, connection))
                    {
                        // Adds the input class id to the classId
                        command.Parameters.Add("@classId", SqlDbType.Int).Value = classId;

                        using (var dataAdapter = new SqlDataAdapter(command))
                        {
                            connection.Open();
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return dataTable;
        }

        /*
         * Gathers the semesters
         * Creates/Returns a data table with the semester description.
         * Cristina Adame   
         */
        public DataTable GetSemesters()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    // Query for table, specific to get semesters 
                    string semesterQuery = "SELECT id, description FROM semester";

                    using (SqlCommand command = new SqlCommand(semesterQuery, connection))
                    {
                        using (var dataAdapter = new SqlDataAdapter(command))
                        {
                            connection.Open();
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return dataTable;
        }

        /*
         * Gathers the semesters the professor teaches given the professorId.
         * Creates/Returns a data table with the semester id and description.
         * Cristina Adame
         */
        public DataTable GetProfessorSemesters(int professorId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    // Query for table, specific to get semesters the professor teaches
                    string classQuery = @"SELECT DISTINCT semester.id, semester.description, semester.start_date 
                                        FROM semester 
                                        INNER JOIN class ON semester.id = class.semester_id 
                                        WHERE class.prof_id = @profId";

                    using (SqlCommand command = new SqlCommand(classQuery, connection))
                    {
                        // Adds the input professor id to the profId
                        command.Parameters.Add("@profId", SqlDbType.Int).Value = professorId;

                        using (var dataAdapter = new SqlDataAdapter(command))
                        {
                            connection.Open();
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return dataTable;
        }

        /*
        * Gathers information of the courses taught by a Professor given the professorId and a semester
        * Creates/Returns a data table with the course id, department name, course number, course section,
        * professor id, start time, end time, and semester.
        * Cristina Adame
        */
        public DataTable GetProfessorSemesterClasses(int professorId, int semesterId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    // Query for table, specific to the class table in the database
                    string profSemQuery = @"SELECT id, department, number, section, prof_id, start_time, end_time, semester_id, name, description 
                                        FROM class 
                                        WHERE prof_id = @professorId AND semester_id = @semesterId";

                    using (SqlCommand command = new SqlCommand(profSemQuery, connection))
                    {
                        // Adds the input professor id to the professorId
                        command.Parameters.Add("@professorId", SqlDbType.Int).Value = professorId;
                        command.Parameters.Add("@semesterId", SqlDbType.Int).Value = semesterId;

                        using (var dataAdapter = new SqlDataAdapter(command))
                        {
                            connection.Open();
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return dataTable;
        }

        /*
         * Gathers information of the quiz passwords and day of week given a class id.
         * Creates/Returns a data table with the quiz id, title, password, and class id.
         * Cristina Adame
         */
        public DataTable GetQuizPasswords(int classId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    // Query for table, specific to the class table in the database
                    string quizQuery = @"SELECT days_of_week.day, quiz.password
                                         FROM quiz 
                                         INNER JOIN class_days ON quiz.class_id = class_days.class_id
                                         INNER JOIN days_of_week ON class_days.day_id = days_of_week.id
                                         WHERE quiz.class_id = @classId";

                    using (SqlCommand command = new SqlCommand(quizQuery, connection))
                    {
                        // Adds the input class id to the classId
                        command.Parameters.Add("@classId", SqlDbType.Int).Value = classId;

                        using (var dataAdapter = new SqlDataAdapter(command))
                        {
                            connection.Open();
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return dataTable;
        }
        //angelica bell
        //gets date of the end of a semester based on course id
        public DateTime getSemStart(int courseId)
        {
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    connection.Open();
                    string query = @"
                    SELECT s.start_date
                    FROM semester s
                    JOIN class c ON s.id = c.semester_id
                    WHERE c.id = @courseId;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@courseId", SqlDbType.Int)).Value = courseId;
                        object result = command.ExecuteScalar();
                        if (result != null && DateTime.TryParse(result.ToString(), out DateTime startDate))
                        {   
                            return startDate;
                        }
                    }
                 }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return DateTime.Today;
            
        }
        //angelica bell
        //gets date of the end of a semester based on course id
        public DateTime getSemEnd(int courseId)
        {
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    connection.Open();
                string query = @"
                SELECT s.end_date
                FROM semester s
                JOIN class c ON s.id = c.semester_id
                WHERE id = @courseId;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@courseId", SqlDbType.Int)).Value = courseId;
                    object result = command.ExecuteScalar();
                    if (result != null && DateTime.TryParse(result.ToString(), out DateTime endDate))
                    {
                        return endDate;

                    }

                }                
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
            return DateTime.Today;
        }
        //angelica bell
        //counts class days in a week
        public int countClassDays(int courseId)
        {
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    connection.Open();
                    string query = @"
                        SELECT COUNT(*)
                        FROM class_days c 
                        WHERE c.class_id = @classId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@classId", courseId);
                        object result = command.ExecuteScalar();
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return 0;
        }
        //angelica bell
        //generates attendance report based on selected filters 
        public DataSet attendanceReport( int classId, bool fullRep, bool conAb, bool moreAb, int abMin, DateTime startDate, DateTime endDate)
        {
            //  weekdays for this class
            var meetingWeekdays = new List<DayOfWeek>();
            using (var conn = GetAzureMySQLConnection())
            using (var cmd = new SqlCommand(@"
        SELECT d.day
        FROM class_days cd
        JOIN days_of_week d ON cd.day_id = d.id
        WHERE cd.class_id = @classId;", conn))
            {
                cmd.Parameters.AddWithValue("@classId", classId);
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                    while (rdr.Read())
                        if (Enum.TryParse(rdr.GetString(0), true, out DayOfWeek d))
                            meetingWeekdays.Add(d);
            }

            //actual meeting dates
            var meetingDates = new List<DateTime>();
            for (var dt = startDate.Date; dt <= endDate.Date; dt = dt.AddDays(1))
                if (meetingWeekdays.Contains(dt.DayOfWeek))
                    meetingDates.Add(dt);
            if (meetingDates.Count == 0)
                throw new InvalidOperationException("empty range.");

            // CTE lines and pivot columns
            string cteLines = string.Join("\nUNION ALL\n", meetingDates.Select(d => $"SELECT '{d:yyyy-MM-dd}' AS Date"));
            string pivotCols = string.Join(", ", meetingDates.Select(d => $"[{d:yyyy-MM-dd}]"));
            string inDateList = string.Join(", ", meetingDates.Select(d => $"'{d:yyyy-MM-dd}'"));
            string meetingDatesCte = $@"; WITH MeetingDates AS ({cteLines})";

            //grid query for full attendance
            string gridQ = fullRep
                ? $@"
                ;WITH MeetingDates AS (
                    {cteLines}
                )
                SELECT p.user_id, u.firstname, u.lastname, {pivotCols}
                FROM (
                    SELECT 
                      usr.id        AS user_id,
                      CONVERT(varchar(10), md.Date, 120) AS Date,
                      CASE WHEN qr.user_id IS NOT NULL THEN 'P' ELSE 'A' END AS Status
                    FROM users AS usr
                    CROSS JOIN MeetingDates AS md
                    LEFT JOIN quiz_records AS qr
                      ON qr.user_id = usr.id
                     AND CONVERT(date, qr.submitted) = md.Date
                    WHERE usr.user_role = 'STUDENT'
                ) AS src
                PIVOT (
                    MAX(Status) FOR Date IN ({pivotCols})
                ) AS p
                JOIN users AS u ON p.user_id = u.id
                ORDER BY u.lastname, u.firstname;"
                : "";
            string gridQX = moreAb
                ? $@"
                SELECT u.id AS user_id, u.firstname, u.lastname, @totalDays - COUNT(q.user_id) AS Absences
                FROM users u 
                LEFT JOIN quiz_records q 
                    ON q.user_id = u.id
                    AND CONVERT(date, q.submitted) IN ({inDateList})
                 WHERE u.user_role = 'STUDENT'
                 GROUP BY u.id, u.firstname, u.lastname
                HAVING (@totalDays - COUNT(q.user_id)) > @threshold"
                :"";
            string gridQC = conAb
                ? $@";
                WITH MeetingDates AS (
                {cteLines} ),
                StudentAttendance AS (
                 SELECT u.id AS user_id, md.Date AS class_date,
                CASE WHEN qr.user_id IS NULL 
                THEN 0 ELSE 1 
                 END                         
                AS Present
                FROM users u
                CROSS JOIN MeetingDates md
                LEFT JOIN quiz_records qr
                    ON qr.user_id = u.id
                    AND CONVERT(date, qr.submitted) = md.Date
                WHERE u.user_role = 'STUDENT' ),
                Numbered AS (
                SELECT user_id, class_date, Present, ROW_NUMBER() 
                OVER (
                PARTITION BY user_id 
                     ORDER BY class_date
                ) AS rn
                FROM StudentAttendance
                ),
                WithLag AS (
                SELECT user_id, class_date, Present,
                LAG(Present, 1) OVER (PARTITION BY user_id ORDER BY class_date) AS Prev1,
                LAG(Present, 2) OVER (PARTITION BY user_id ORDER BY class_date) AS Prev2
                FROM Numbered
                )
                SELECT DISTINCT u.student_id, u.firstname, u.lastname
                FROM WithLag wl
                JOIN users u 
                    ON wl.user_id = u.id
                WHERE wl.Present = 0 
                AND wl.Prev1   = 0 
                AND wl.Prev2   = 0
               ORDER BY u.lastname, u.firstname;"
                : "";

            // summary query
            string summQ = "";
            if (moreAb || fullRep)
            {
                // summary for both fullRep  and moreAb 
                            summQ = $@"
            SELECT 
                u.id        AS user_id,
                u.firstname,
                u.lastname,
                @totalDays - COUNT(qr.user_id) AS Absences
            FROM users AS u
            LEFT JOIN quiz_records AS qr
              ON qr.user_id = u.id
             AND CONVERT(date, qr.submitted) IN ({inDateList})
            WHERE u.user_role = 'STUDENT'
            GROUP BY u.id, u.firstname, u.lastname
            " + (moreAb
                            ? "HAVING (@totalDays - COUNT(qr.user_id)) > @threshold;"
                            : "");
                        }

            // combined SQL
            string combine = string.Join("\n", new[] { gridQ, gridQC, gridQX }.Where(sql => !string.IsNullOrWhiteSpace(sql)));
            using (var conn = GetAzureMySQLConnection())
            using (var cmd = new SqlCommand(combine + Environment.NewLine + summQ, conn))
            {
                cmd.Parameters.AddWithValue("@classId", classId);
                cmd.Parameters.AddWithValue("@totalDays", meetingDates.Count);
                if (moreAb)
                    cmd.Parameters.AddWithValue("@threshold", abMin);
                
                
                conn.Open();
                var ds = new DataSet();
                using (var da = new SqlDataAdapter(cmd))
                    da.Fill(ds);
                return ds;
            }
        }

       //angelica bell
       //adds students to user table from a csv
        public void insertAttendenceRec(DataTable csvTable)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {

                    connection.Open();
                    foreach (DataRow row in csvTable.Rows)
                    {
                        string loginId = row["Username"].ToString();
                        string fName = row["First Name"].ToString();
                        string lName = row["Last Name"].ToString();
                        string studentId = row["Student ID"].ToString();
                        string query = @"IF NOT EXISTS (SELECT 1 FROM [users] WHERE login_id = @loginId)
                        BEGIN
                            INSERT INTO [users] (login_id, firstname, lastname, student_id, passcode, user_role)
                            VALUES (@loginId, @firstName, @lastName, @studentId, @password, @userRole)
                        END";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@loginId", loginId);
                            command.Parameters.AddWithValue("@firstName", fName);
                            command.Parameters.AddWithValue("@lastName", lName);
                            command.Parameters.AddWithValue("@studentId", studentId);
                            command.Parameters.AddWithValue("@password", null);
                            command.Parameters.AddWithValue("@userRole", "STUDENT");

                            command.ExecuteNonQuery();
                        }


                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }

        }
        //angelica bell
        //pulls attendance status based on a day.
        public DataTable getStudentQuizzesForDay(DateTime day)
        {
            DataTable dataTable = new DataTable();
            //if student has a entry in quiz_records for a certian day, they are displayed as present else displayed as absent 
            string query = @"
                Select u.student_id, u.firstname, u.lastname, 
                    CASE WHEN q.user_id IS NOT NULL THEN 'Present' ELSE 'Absent' END AS attendance
                FROM users AS u
                LEFT JOIN (
                    SELECT DISTINCT user_id 
                    FROM quiz_records 
                    WHERE CAST(submitted AS DATE) = @SelectedDate
                ) AS q 
                   ON u.id =  q.user_id
                WHERE u.user_role = 'STUDENT'
                ORDER BY u.lastname, u.firstname;
            ";
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@SelectedDate", SqlDbType.Date)).Value = day;

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);



                    }
                }
                return dataTable;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
            return dataTable;
        }
        //changes attendance status based on user input
        public void changeAttendenceRecord(string student_id, DateTime day, string status)
        {
            try
            {

                using (var connection = GetAzureMySQLConnection())
                {
                    string query = "";
                    connection.Open();
                    //inserts into quiz_records to change status to present 
                    if (status == "Present") {
                        query = @"
                            INSERT INTO quiz_records (quiz_id, user_id, submitted, status)
                                SELECT 1, u.id, @Date, 'excused' 
                                FROM users u 
                            WHERE u.student_id = @student_id
                                AND NOT EXISTS (
                                    SELECT 1 FROM quiz_records q
                                    WHERE q.user_id = u.id AND CAST(q.submitted AS DATE) = @Date
                                )";
                    }
                    else
                    {//deletes from quiz_records to change status to absent 
                        query = @"
                            DELETE FROM quiz_records q
                                WHERE q.user_id = @student_id AND CAST(q.submitted AS DATE) = @Date;
                                ";
                    }
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@student_id", student_id);
                            command.Parameters.AddWithValue("@Date", day);

                            command.ExecuteNonQuery();

                        }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
        }

        // Return any existing quizes for a given class
        // Olivia Anderson
        public DataTable GetCourseQuizzes(int courseId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {


                    // Query for table, specific to the class table in the database
                    string quizQuery = @"select id, title, password, validate_answers from quiz where class_id = @courseId ";
                    using (SqlCommand command = new SqlCommand(quizQuery, connection))
                    {
                        command.Parameters.Add("@courseId", SqlDbType.Int).Value = courseId;
                        using (var dataAdapter = new SqlDataAdapter(command))
                        {
                            connection.Open();
                            dataAdapter.Fill(dataTable);

                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return dataTable;
        }


        /*
         * Create a new Quiz entry given the provided information and return the id
         *  for the newly created quiz
         *  Olivia Anderson
        */
        public int CreateNewQuiz(string title, string passcode, bool validatequiz, int courseId)
        {
            int newQuizId = 0;

            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    connection.Open();
                    // Insert a new quiz record into the Azure database, then
                    // select the last id added to the database.
                    string quizInsert = @"INSERT INTO quiz (title, password, class_id, validate_answers) 
                                 VALUES (@title, @passcode, @classId, @valanswers); 
                                 SELECT SCOPE_IDENTITY();";
                    // Azure SQL needs to useL:   SELECT SCOPE_IDENTITY();
                    // instead of LAST_INSERT_ID() which is for MySQL

                    using (SqlCommand command = new SqlCommand(quizInsert, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@title", title);
                        command.Parameters.AddWithValue("@passcode", passcode);
                        command.Parameters.AddWithValue("@classId", courseId);
                        command.Parameters.AddWithValue("@valanswers", validatequiz ? 'T' : 'F'); 

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            newQuizId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error inserting quiz: " + e.Message);
            }

            return newQuizId;
        }

        /*
         * Empty method to insert a new class
         */
        public void InsertNewClass(string department, string number, string section, string profId, 
                                    string startTime, string endTime, int semesterId, string name, string description)
        {

        }

        /*
         * Collects infomation about the quiz questions and answers
         * Olivia Anderson
        */
        public DataSet GetQuizData(int quizId)
        {
            DataSet quizDataSet = new DataSet();
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    connection.Open();
                    // select statments to get info about the quiz questions and answers
                    string sqlQuery = @"
                    -- Get quiz details
                    SELECT id, title, password, validate_answers 
                    FROM quiz 
                    WHERE id = @quizId;

                    -- Get related quiz questions
                    SELECT quiz_id, question_id 
                    FROM quiz_question;

                    -- Get question details
                    SELECT id AS question_id, question_text 
                    FROM question;

                    -- Get answers
                    -- SELECT id as answer_id, question_id, answer_text, correct_value FROM answer;
                    SELECT 
                        id AS answer_id, 
                        question_id, 
                        answer_text, 
                        COALESCE(correct_value, 'default_value') AS correct_value
                    FROM answer;
                ";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@quizId", quizId);

                        // Fill DataSet with multiple tables
                        adapter.Fill(quizDataSet);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error inserting quiz: " + e.Message);
            }

            return quizDataSet;
        }

        // Collects only the question for a quiz
        // Olivia Anderson
        public DataTable GetQuestions(int courseId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    // Query for table, specific to the class table in the database
                    string quizQuery = @"SELECT id AS question_id, question_text FROM question 
                                            where class_id = @courseId ";
                    using (SqlCommand command = new SqlCommand(quizQuery, connection))
                    {
                        command.Parameters.Add("@courseId", SqlDbType.Int).Value = courseId;
                        using (var dataAdapter = new SqlDataAdapter(command))
                        {
                            connection.Open();
                            dataAdapter.Fill(dataTable);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return dataTable;
        }

        // Links a set of questions to a quiz
        // Olivia Anderson
        public bool AssociateQuestion(int quizId, int questionId)
        {
            bool assocResult = false;
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    connection.Open();
                    // Insert a new quiz association record into the Azure database.
                    string associateQuizInsert = @"INSERT into quiz_question (quiz_id, question_id) VALUES (@quizId, @questionId) ";
                    using (SqlCommand command = new SqlCommand(associateQuizInsert, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@quizId", quizId);
                        command.Parameters.AddWithValue("@questionId", questionId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error adding the association between a quiz and question: " + e.Message);
            }
            return assocResult;
        }

       
        /*
         * Insert the new question into the question TABLE and associate the 
         * question with the quiz by inserting a new entry into the 
         * quiz_question TABLE.
         * Olivia Anderson
         */
        public int InsertQuestion(int classId, int quizId, int questionId, string value, ref Dictionary<int, int> newQuestionMapping)
        {
            int newQuestionId = 0;
            int tempQuestionId = questionId;
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    connection.Open();
                    // Insert a new quiz record into the Azure database, then
                    // select the last id added to the database.
                    string questionInsert = @"INSERT into question (question_text, class_id) VALUES (@questionText, @classId);
                                         SELECT SCOPE_IDENTITY();  ";
                    // Azure SQL needs to useL:   SELECT SCOPE_IDENTITY();
                    //     instead of LAST_INSERT_ID()
                    using (SqlCommand command = new SqlCommand(questionInsert, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@questionText", value);
                        command.Parameters.AddWithValue("@classId", classId);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            newQuestionId = Convert.ToInt32(result);
                        }
                    }
                    newQuestionMapping.Add(tempQuestionId, newQuestionId);
                    if (newQuestionId > 0)
                    {
                        // This is a new question that needs to be associated with
                        // the quiz the user is editing.
                        string associateQuizInsert = @"INSERT into quiz_question (quiz_id, question_id) VALUES (@quizId, @questionId) ";
                        using (SqlCommand command = new SqlCommand(associateQuizInsert, connection))
                        {
                            // Set parameter values
                            command.Parameters.AddWithValue("@quizId", quizId);
                            command.Parameters.AddWithValue("@questionId", newQuestionId);

                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inserting question: " + e.Message);
            }
            return newQuestionId;
        }

        // Allows the user to modify a question
        // Olivia Anderson
        public bool UpdateQuestion(int questionId, string newValue)
        {
            // IF the questionId is less then 1 an error must have occured.
            if (questionId < 1)
            {
                return false;
            }
            bool updateResult = false;
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    connection.Open();
                    // Update an existing question in the Azure database.
                    string questionUpdate = @"UPDATE question
                                           SET question_text = @questionText
                                        WHERE id = @questionId ";
                    // TODO: Azure SQL needs to useL:   SELECT SCOPE_IDENTITY();
                    //     instead of LAST_INSERT_ID()
                    using (SqlCommand command = new SqlCommand(questionUpdate, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@questionText", newValue);
                        command.Parameters.AddWithValue("@questionId", questionId);

                        command.ExecuteScalar();
                        updateResult = true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inserting quiz: " + e.Message);
            }
            return updateResult;
        }

        // Deletes a question
        // It checks to see if there is more than one quiz associated with the question
        // If there another quiz it just removes the reference
        // If there is no other quiz it deletes the question
        // Olivia Anderson
        public int DeleteQuestion(int questionId, int quizId)
        {
            int alteredrows = 0;
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    connection.Open();
                    int associationCount = 0;
                    // Query to check if there are any other quiz associates of the question 
                    // before completely deleting the    question. If there are multiple quiz associations,
                    // remove the association for this quiz but do NOT delete the question.
                    // When there is only 1 association then delete both the association and
                    // the question.
                    //
                    string quizQuery = @"select count(*) from quiz_question where question_id = @questionId ";
                    using (SqlCommand command = new SqlCommand(quizQuery, connection))
                    {
                        command.Parameters.Add("@questionId", SqlDbType.Int).Value = questionId;

                        // Need to execute the query and collect the value from the count(*)
                        // ExecuteScalar() returns the single value from COUNT(*)
                        object result = command.ExecuteScalar();
                        associationCount = result != null ? Convert.ToInt32(result) : 0;
                    }

                    // Insert a new quiz record into the Azure database, then
                    // select the last id added to the database.
                    string quizQuestionDelete = @"DELETE FROM quiz_question WHERE quiz_id = @quizId and question_id = @questionId ";
                    using (SqlCommand command = new SqlCommand(quizQuestionDelete, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@quizId", quizId);
                        command.Parameters.AddWithValue("@questionId", questionId);
                        command.ExecuteNonQuery();
                    }

                    if (associationCount <= 1)
                    {
                        // Delete the question record from database, if
                        // it was associated with only 1 quiz.
                        string questionDelete = @"DELETE FROM question WHERE id = @questionId ";
                        using (SqlCommand command = new SqlCommand(questionDelete, connection))
                        {
                            // Set parameter values
                            command.Parameters.AddWithValue("@questionId", questionId);
                            alteredrows = command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error deleting quiz: " + e.Message);
            }
            return alteredrows;
        }

        
        /*
         * Insert the new answer into the answer TABLE. Set the correct_value
         * column to either 'F' or 'T'. 
         * Olivia Anderson
         */
        public int InsertAnswer(int questionId, string value, string isCorrectAnswer)
        {
            int newAnswerId = 0;
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    connection.Open();
                    // Answer table columns: id, question_id, answer_text, correct_value
                    // Insert a new answer record into the Azure database, then
                    // select the last id added to the database.
                    string questionInsert = @"INSERT into answer (question_id, answer_text, correct_value) VALUES 
                                               (@questionId, @answerText, @correctValue); 
                                            SELECT SCOPE_IDENTITY(); ";
                    // Azure SQL needs to use:   SELECT SCOPE_IDENTITY();
                    //     instead of LAST_INSERT_ID() like MySQL.
                    using (SqlCommand command = new SqlCommand(questionInsert, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@questionId", questionId);
                        command.Parameters.AddWithValue("@answerText", value);
                        command.Parameters.AddWithValue("@correctValue", isCorrectAnswer);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            newAnswerId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inserting an answer: " + e.Message);
            }
            return newAnswerId;
        }

        /*
         * If this is an update, the answer id cannot be less than 1. When adding
         * a new answer, the answer id is a negative number as a placeholder.
         */
        public bool UpdateAnswer(int answerId, string value, string isCorrectAnswer)
        {
            // IF the questionId is less then 1 an error must have occured.
            if (answerId < 1)
            {
                return false;
            }
            bool updateResult = false;
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    connection.Open();
                    // Answer table columns: id, question_id, answer_text, correct_value
                    // Update an existing answer in the Azure database.
                    string answerUpdate = @"UPDATE answer
                                           SET answer_text = @answerText,
                                               correct_value = @isCorrectAnswer
                                        WHERE id = @answerId ";
                    using (SqlCommand command = new SqlCommand(answerUpdate, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@answerText", value);
                        command.Parameters.AddWithValue("@isCorrectAnswer", isCorrectAnswer);
                        command.Parameters.AddWithValue("@answerId", answerId);

                        command.ExecuteScalar();
                        updateResult = true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inserting an answer: " + e.Message);
            }
            return updateResult;
        }
        /*
         * The answer can be delete just by matching the question_id and answer id
         * Olivia Anderson
         */
        public int DeleteAnswer(int answerId, int questionId)
        {
            int alteredrows = 0;
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    connection.Open();
                    int associationCount = 0;
                    if (associationCount <= 1)
                    {
                        // An answer can only be associated with a single question.
                        string questionDelete = @"DELETE FROM answer WHERE id = @answerId and question_id = @questionId  ";
                        using (SqlCommand command = new SqlCommand(questionDelete, connection))
                        {
                            // Set parameter values
                            command.Parameters.AddWithValue("@answerId", answerId);
                            command.Parameters.AddWithValue("@questionId", questionId);
                            alteredrows = command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error deleting answer: " + e.Message);
            }
            return alteredrows;
        }

        /*
         * Takes the course information and inserts the class into the database.
         * Returns the class id so that it can be used to add the days of the week
         * Cristina Adame
         */
        public int CreateClass(int profId, string department, string number, string section, TimeSpan startTime, TimeSpan endTime, string name, string description, int semester)
        {
            // Stores the class id
            int classId = -1;
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    connection.Open();
                    
                    //SQL query to insert the class into the classes table
                    string classInsert = @"INSERT INTO class (department, number, section, prof_id, start_time, end_time, semester_id, name, description) 
                                 VALUES (@department, @number, @section, @profId, @startTime, @endTime, @semesterId, @name, @description); 
                                 SELECT SCOPE_IDENTITY();";
                    
                    using (SqlCommand command = new SqlCommand(classInsert, connection))
                    {
                        // Insert the class details
                        command.Parameters.AddWithValue("@department", department);
                        command.Parameters.AddWithValue("@number", number);
                        command.Parameters.AddWithValue("@section", section);
                        command.Parameters.AddWithValue("@profId", profId);
                        command.Parameters.AddWithValue("@startTime", startTime);
                        command.Parameters.AddWithValue("@endTime", endTime);
                        command.Parameters.AddWithValue("@semesterId", semester);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@description", description);
                        object result = command.ExecuteScalar();

                        // Get the last inserted id
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            classId = id;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inserting class: " + e.Message);
            }

            return classId;
        }
        /*
         * Add days that the class in session into the database.
         * Takes the class id and the day id.
         * Cristina Adame
         */
        public void AddClassDays(int classId, int dayId)
        {
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    connection.Open();

                    // SQL query to add day the class in session
                    string classInsert = @"INSERT INTO class_days (class_id, day_id) 
                                 VALUES (@classId, @dayId); ";
                    
                    using (SqlCommand command = new SqlCommand(classInsert, connection))
                    {
                        // Insert values
                        command.Parameters.AddWithValue("@classId", classId);
                        command.Parameters.AddWithValue("@dayId", dayId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inserting class days: " + e.Message);
            }
        }
       
        /*
         * Get the days of the week that the class is in session.
         * Takes the class id and returns a list of the days of the week class is in session.
         * Cristina Adame
         */
        public List<string> GetClassDays(int classId)
        {
            List<string> days = new List<string>();


            try
            {
                using (var connection = GetAzureMySQLConnection())
                {

                    connection.Open();

                    // SQL query to add day the class in session
                    string classDays = @"SELECT days_of_week.day
                                         FROM class_days
                                         JOIN days_of_week ON class_days.day_id = days_of_week.id
                                         WHERE class_days.class_id = @classId
                                         ORDER BY days_of_week.id;";

                    using (SqlCommand command = new SqlCommand(classDays, connection))
                    {
                        command.Parameters.AddWithValue("@classId", classId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                days.Add(reader.GetString(0));
                            }
                        }

                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error inserting class days: " + e.Message);
            }
            return days;
        }
        /*
         * Get the passwords for the quizzes in a class.
         * Takes the class id and returns a datatable with the quiz passwords.
         * Cristina Adame
         */
        public DataTable GetClassPasswords(int classId)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    connection.Open();

                    // Password query to get the passwords for the quizzes for the class
                    string passwordQuery = "SELECT password FROM quiz WHERE class_id = @classId";

                    using (SqlCommand command = new SqlCommand(passwordQuery, connection))
                    {
                        command.Parameters.AddWithValue("@classId", classId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error filling DataGridView with quiz passwords: " + e.Message);
            }

            return dataTable;
        }


        // verfies that the professor id and password combination exists
        // write by Shuang Jiang(sxj220054) (4/17) modified 
        public int ProfVerification(string user, string password)
        {
            int count = 0;

            Debug.WriteLine("user: " + user);
            Debug.WriteLine("password: " + password);
            //Debug.WriteLine("database: " + database_name);

            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    string query = "SELECT COUNT(*) FROM users WHERE student_id=@username AND passcode=@password AND user_role='PROF'";

                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", user);
                        cmd.Parameters.AddWithValue("@password", password);
                        object countObject = cmd.ExecuteScalar();
                        // If ExecuteScalar returns null convert to 0
                        count = countObject != null ? Convert.ToInt32(countObject) : 0;

                        Debug.WriteLine("count: " + count);
                        connection.Close();
                    }

                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                Debug.WriteLine(e.ToString());
            }

            return count;
        }

        /*        
         * Get the professor id given the username
         * Takes the username and returns the professor id.
         * Cristina Adame
         */
        public int GetProfessorId(string user)
        {
            int id = 0;
            try
            {
                using (var connection = GetAzureMySQLConnection())
                {
                    string query = "SELECT id FROM users WHERE student_id=@username AND user_role='PROF'";
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", user);
                        object idObject = cmd.ExecuteScalar();
                        // If ExecuteScalar returns null convert to 0
                        id = idObject != null ? Convert.ToInt32(idObject) : 0;
                        Debug.WriteLine("id: " + id);
                        connection.Close();
                    }
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                Debug.WriteLine(e.ToString());
            }
            return id;
        }




    }
}
