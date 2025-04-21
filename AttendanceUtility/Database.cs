/* Database
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
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceUtility
{
    public class Database
    {
        private string db_server = "";
        private string database_name = "";
        private string db_user = "";
        string db_pwd = "";

        // Ideally the password should be encrypted and the Database object will know how to decrypt.
        public Database(string server, string name, string uname, string encrypted_pwd)
        {
            db_server = server;
            database_name = name;
            db_user = uname;
            // TODO: The encryption and decryption needs to be added.
            db_pwd = encrypted_pwd;
        }

        // get connect to sql server
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
         * Gathers the semesters the professor teaches given the professorId.
         * Creates/Returns a data table with the semester id and description.
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
    }
}
