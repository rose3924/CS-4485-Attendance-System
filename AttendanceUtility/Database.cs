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
    }
}
