/*
 * Creation of the LoginScreen Page for continuity purposes.
 * Will be completed by Shuang Jiang
 * 
 * Has a 'login' button to function for moving to the next page
 * 
 * Written by Cristina Adame (caa220007)
 * starting March 28, 2025
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
    public partial class LoginScreen : Form
    {
        // Instance of database object
        private Database dbobject;

        // Professor ID, following succesful login
        private int profId = 3;

        public LoginScreen(Database dbobject)
        {
            InitializeComponent();
            this.dbobject = dbobject;
        }

        /*
         * Closes current form and opens the classes page for the Professor.
         * Not complete, just for testing.
         * Actual successful login will need verifiacation and to store the Professor ID
         */
        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new ClassesHomePage(dbobject, profId).Show();
        }
    }
}
