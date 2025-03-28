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
            maintabControl.Location = new Point(3, 55);
            maintabControl.Name = "maintabControl";
            maintabControl.SelectedIndex = 0;
            maintabControl.Size = new Size(796, 391);
            maintabControl.TabIndex = 0;
            // 
            // usertabpage
            // 
            usertabpage.Controls.Add(userdatagridview);
            usertabpage.Location = new Point(4, 29);
            usertabpage.Name = "usertabpage";
            usertabpage.Padding = new Padding(3);
            usertabpage.Size = new Size(788, 358);
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
            userdatagridview.Location = new Point(3, 3);
            userdatagridview.MultiSelect = false;
            userdatagridview.Name = "userdatagridview";
            userdatagridview.ReadOnly = true;
            userdatagridview.RowHeadersWidth = 51;
            userdatagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userdatagridview.Size = new Size(782, 352);
            userdatagridview.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(788, 358);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // testconnectionbutton
            // 
            testconnectionbutton.Location = new Point(112, 12);
            testconnectionbutton.Name = "testconnectionbutton";
            testconnectionbutton.Size = new Size(147, 27);
            testconnectionbutton.TabIndex = 1;
            testconnectionbutton.Text = "Test Connection";
            testconnectionbutton.UseVisualStyleBackColor = true;
            testconnectionbutton.Click += testconnectionbutton_Click;
            // 
            // AttandenceUtility
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(testconnectionbutton);
            Controls.Add(maintabControl);
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
    }
}
