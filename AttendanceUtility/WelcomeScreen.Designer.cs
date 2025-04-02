namespace AttendanceUtility
{
    partial class WelcomeScreen
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
            testconnectionbutton = new Button();
            WelcomeLabel = new Label();
            SuggestionBox = new TextBox();
            maintabControl.SuspendLayout();
            usertabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userdatagridview).BeginInit();
            SuspendLayout();
            // 
            // maintabControl
            // 
            maintabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            maintabControl.Controls.Add(usertabpage);
            maintabControl.Location = new Point(4, 461);
            maintabControl.Margin = new Padding(4);
            maintabControl.Name = "maintabControl";
            maintabControl.SelectedIndex = 0;
            maintabControl.Size = new Size(533, 135);
            maintabControl.TabIndex = 0;
            // 
            // usertabpage
            // 
            usertabpage.Controls.Add(userdatagridview);
            usertabpage.Location = new Point(4, 34);
            usertabpage.Margin = new Padding(4);
            usertabpage.Name = "usertabpage";
            usertabpage.Padding = new Padding(4);
            usertabpage.Size = new Size(525, 97);
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
            userdatagridview.Size = new Size(517, 89);
            userdatagridview.TabIndex = 0;
            // 
            // testconnectionbutton
            // 
            testconnectionbutton.Location = new Point(677, 523);
            testconnectionbutton.Margin = new Padding(4);
            testconnectionbutton.Name = "testconnectionbutton";
            testconnectionbutton.Size = new Size(184, 34);
            testconnectionbutton.TabIndex = 1;
            testconnectionbutton.Text = "Test Connection";
            testconnectionbutton.UseVisualStyleBackColor = true;
            testconnectionbutton.Click += testconnectionbutton_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(383, 242);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(217, 60);
            WelcomeLabel.TabIndex = 3;
            WelcomeLabel.Text = "Welcome";
            // 
            // SuggestionBox
            // 
            SuggestionBox.BackColor = Color.WhiteSmoke;
            SuggestionBox.Location = new Point(625, 485);
            SuggestionBox.Name = "SuggestionBox";
            SuggestionBox.Size = new Size(298, 31);
            SuggestionBox.TabIndex = 4;
            SuggestionBox.Text = "Add a progress bar??";
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(960, 600);
            Controls.Add(SuggestionBox);
            Controls.Add(WelcomeLabel);
            Controls.Add(testconnectionbutton);
            Controls.Add(maintabControl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "WelcomeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WelcomeScreen";
            Load += WelcomeScreen_Load;
            maintabControl.ResumeLayout(false);
            usertabpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userdatagridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl maintabControl;
        private TabPage usertabpage;
        private Button testconnectionbutton;
        private DataGridView userdatagridview;
        private Label WelcomeLabel;
        private TextBox SuggestionBox;
    }
}
