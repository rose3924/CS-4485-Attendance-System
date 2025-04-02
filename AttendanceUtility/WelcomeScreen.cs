using Microsoft.Data.SqlClient;
using System.Data;

namespace AttendanceUtility
{
    public partial class WelcomeScreen: Form
    {
        // Instance of database object
        private Database dbobject = null;
        public WelcomeScreen ()
        {
            InitializeComponent();

            dbobject = InitDbObject();
        }

        // 
        private Database InitDbObject()
        {
            string dbserver = AttendanceUtility.Properties.Settings.Default.DBServer;
            string dbname = AttendanceUtility.Properties.Settings.Default.DatabaseName;
            string dbuser = AttendanceUtility.Properties.Settings.Default.DBUser;
            string dbpwd = AttendanceUtility.Properties.Settings.Default.DBPassword;
            return new Database(dbserver, dbname, dbuser, dbpwd);
        }


        private void testconnectionbutton_Click(object sender, EventArgs e)
        {
            if (dbobject == null)
            {
                dbobject = InitDbObject();
            }
            try
            {
                DataTable usertable = dbobject.GetStudents();
                userdatagridview.DataSource = usertable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Method to wait for 3 seconds then move to login screen
        private async void MoveToLoginScreen()
        {
            dbobject = InitDbObject();
            await Task.Delay(5000);
            this.Hide();
            new LoginScreen(dbobject).Show();
        }

        // Method to move to login screen when loading
        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            MoveToLoginScreen();
        }
    }
}
