namespace AttendanceUtility
{
    partial class AttandenceUtility
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            maintabControl = new TabControl();
            usertabpage = new TabPage();
            userdatagridview = new DataGridView();
            tabPage2 = new TabPage();
            testconnectionbutton = new Button();
            LoginTesterButton = new Button();
            maintabControl.SuspendLayout();
            usertabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userdatagridview).BeginInit();
            SuspendLayout();
            // 
            // maintabControl
            // 
            maintabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            maintabControl.Controls.Add(usertabpage);
            maintabControl.Controls.Add(tabPage2);
            maintabControl.Location = new Point(4, 69);
            maintabControl.Margin = new Padding(4);
            maintabControl.Name = "maintabControl";
            maintabControl.SelectedIndex = 0;
            maintabControl.Size = new Size(933, 471);
            maintabControl.TabIndex = 0;
            // 
            // usertabpage
            // 
            usertabpage.Controls.Add(userdatagridview);
            usertabpage.Location = new Point(4, 34);
            usertabpage.Margin = new Padding(4);
            usertabpage.Name = "usertabpage";
            usertabpage.Padding = new Padding(4);
            usertabpage.Size = new Size(925, 433);
            usertabpage.TabIndex = 0;
            usertabpage.Text = "User";
            usertabpage.UseVisualStyleBackColor = true;
            // 
            // userdatagridview
            // 
            userdatagridview.AllowUserToAddRows = false;
            userdatagridview.AllowUserToDeleteRows = false;
            userdatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userdatagridview.Dock = DockStyle.Fill;
            userdatagridview.EditMode = DataGridViewEditMode.EditProgrammatically;
            userdatagridview.Location = new Point(4, 4);
            userdatagridview.Margin = new Padding(4);
            userdatagridview.MultiSelect = false;
            userdatagridview.Name = "userdatagridview";
            userdatagridview.ReadOnly = true;
            userdatagridview.RowHeadersWidth = 51;
            userdatagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userdatagridview.Size = new Size(917, 425);
            userdatagridview.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(925, 433);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // testconnectionbutton
            // 
            testconnectionbutton.Location = new Point(140, 15);
            testconnectionbutton.Margin = new Padding(4);
            testconnectionbutton.Name = "testconnectionbutton";
            testconnectionbutton.Size = new Size(184, 34);
            testconnectionbutton.TabIndex = 1;
            testconnectionbutton.Text = "Test Connection";
            testconnectionbutton.UseVisualStyleBackColor = true;
            testconnectionbutton.Click += testconnectionbutton_Click;
            // 
            // LoginTesterButton
            // 
            LoginTesterButton.Location = new Point(565, 15);
            LoginTesterButton.Name = "LoginTesterButton";
            LoginTesterButton.Size = new Size(197, 35);
            LoginTesterButton.TabIndex = 2;
            LoginTesterButton.Text = "Login";
            LoginTesterButton.UseVisualStyleBackColor = true;
            LoginTesterButton.Click += LoginTesterButton_Click;
            // 
            // AttandenceUtility
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 544);
            Controls.Add(LoginTesterButton);
            Controls.Add(testconnectionbutton);
            Controls.Add(maintabControl);
            Margin = new Padding(4);
            Name = "AttandenceUtility";
            Text = "Attendance Maintenance";
            maintabControl.ResumeLayout(false);
            usertabpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userdatagridview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl maintabControl;
        private TabPage usertabpage;
        private TabPage tabPage2;
        private Button testconnectionbutton;
        private DataGridView userdatagridview;
        private Button LoginTesterButton;
    }
}
