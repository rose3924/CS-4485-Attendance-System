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
    //Page displays the classes of the professor
    public partial class ClassesHomePage : Form
    {
        // Instance of database object
        private Database dbobject = null;

        public ClassesHomePage(Database dbobject)
        {
            InitializeComponent();
            this.dbobject = dbobject;
        }

        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            // Close the current form and show the login form
            this.Close();
            new LoginScreen(dbobject).Show();
        }
    }
}
