/*
 * WelcomeScreen.cs
 * 
 * Welcome Screen for the Professor Desktop app. Also functions as the starter form.
 * Welcomes the user and after three seconds moves to the login screen.
 * 
<<<<<<< HEAD
 * For connection testing, the 'testconnectionbutton' remains.
 * 
=======
>>>>>>> 0353722a6c9c80f7c9cbdba7f4aa5c45a2762bcb
 * Written by Shuang Jiang (SXJ220054) 
 * Contributor Olivia Anderson (ova210001) and Cristina Adame (caa220007)
 * 
 */
using Microsoft.Data.SqlClient;
using System.Data;

namespace AttendanceUtility
{
    public partial class WelcomeScreen : Form
    {
        // Instance of database object
        private Database dbobject;
        public WelcomeScreen()
        {
            InitializeComponent();
            dbobject = InitDbObject();
        }

        /*
         * Creation of the database
         */
        private Database InitDbObject()
        {
            string dbserver = AttendanceUtility.Properties.Settings.Default.DBServer;
            string dbname = AttendanceUtility.Properties.Settings.Default.DatabaseName;
            string dbuser = AttendanceUtility.Properties.Settings.Default.DBUser;
            string dbpwd = AttendanceUtility.Properties.Settings.Default.DBPassword;
            return new Database(dbserver, dbname, dbuser, dbpwd);
        }

        /*
         * Creates instance of database if it does not exits, connects to database and loads students.
         * Likely to be deleted toward end of project
         */
        private void wakeupDatabase()
        {
            if (dbobject == null)
            {
                dbobject = InitDbObject();
            }
            try
            {
                // Initiate a query to wake up the database.
                // The Azure cloub database is configure to go to sleep
                // when no one is using it. For this project, we are using
                // the free version of this from Microsoft. However,
                // it is only free for a limit amount of time each month.
                // Once the limit is reached it begins to accrue charges.
                // It's better to let it sleep as much as possible.
                DataTable usertable = dbobject.GetStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        /*
         * Creates instance of database, hides welcome screen(starter screen), and loads a login screen.
         */
        private async void MoveToLoginScreen()
        {
            if (dbobject == null)
            {
                dbobject = InitDbObject();
            }
            // Add ProgressBar
            welcomeProgressBar.MarqueeAnimationSpeed = 30; // Adjust animation speed

            await Task.Delay(5000);
            this.Hide();
            new LoginScreen(dbobject).Show();
        }

        /*
         * Calls for login screen as the WelcomeScreen loads
         */
        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            wakeupDatabase();
            MoveToLoginScreen();
        }

    }
}
