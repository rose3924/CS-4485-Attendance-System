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
    public partial class ClassesHomePage : Form
    {
        // Form to go back to login screen when logging out
        private Form loginForm;

        // Modified constructor to take in login form
        public ClassesHomePage(Form login)
        {
            InitializeComponent();

            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;
            // Set the login form to the form passed in
            this.loginForm = login;
        }

        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            // Close the current form and show the login form
            this.Close();
            loginForm.Show();
        }
    }
}
