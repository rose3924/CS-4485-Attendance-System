/*
 * Creation of the LoginScreen Page for continuity purposes.
 * 
 * Has a 'login' button to function for moving to the next page
 * 
 * Written by Shuang Jiang (sxj220054) and 
 * Contributor Cristina Adame (caa220007)
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

            // hide the warning image and the msg before type any invalid input(s) - ID, password
            labelError.Hide();
            pictureBoxWarning.Hide();
        }

        /*
         * Closes current form and opens the classes page for the Professor.
         * Not complete, just for testing.
         * Actual successful login will need verifiacation and to store the Professor ID
         */
        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Once they click the login button, hide the error information
            // before validating. 
            labelError.Hide();
            pictureBoxWarning.Hide();

            // Verify the text fields are not empty
            if (textBoxID.Text.Trim().Equals("") || textBoxPassword.Text.Trim().Equals(""))
            {
                labelError.Show();
                pictureBoxWarning.Show();
                return;
            }
            // If the text fields are not empty, check the database.
            int count = dbobject.ProfVerification(textBoxID.Text, textBoxPassword.Text);
            if (count == 0)
            {
                labelError.Show();
                pictureBoxWarning.Show();
                return;
            }
            this.Close();
            new ClassesHomePage(dbobject, profId).Show();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            // Close all the application forms and stop the application.
            Application.Exit(); 
        }
    }
}
