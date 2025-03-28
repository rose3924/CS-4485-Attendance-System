using Microsoft.Data.SqlClient;
using System.Data;

namespace AttendanceUtility
{
    public partial class AttandenceUtility : Form
    {
        //instance of database object
        private Database dbobject = null;
        public AttandenceUtility()
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
    }
}
