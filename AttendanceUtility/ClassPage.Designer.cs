namespace AttendanceUtility
{
    partial class ClassPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassPage));
            BannerPanel = new Panel();
            LogoutLabel = new Label();
            HomeIcon = new PictureBox();
            CourseLabel = new Label();
            UTDLogoBox = new PictureBox();
            AttendanceButton = new Button();
            PasswordButton = new Button();
            QuizzesButton = new Button();
            EnrollmentButton = new Button();
            ClassDetailsButton = new Button();
            BannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).BeginInit();
            SuspendLayout();
            // 
            // BannerPanel
            // 
            BannerPanel.BackColor = Color.FromArgb(29, 75, 54);
            BannerPanel.Controls.Add(LogoutLabel);
            BannerPanel.Controls.Add(HomeIcon);
            BannerPanel.Controls.Add(CourseLabel);
            BannerPanel.Controls.Add(UTDLogoBox);
            BannerPanel.Dock = DockStyle.Top;
            BannerPanel.Location = new Point(0, 0);
            BannerPanel.Name = "BannerPanel";
            BannerPanel.Size = new Size(960, 103);
            BannerPanel.TabIndex = 1;
            // 
            // LogoutLabel
            // 
            LogoutLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LogoutLabel.AutoSize = true;
            LogoutLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutLabel.ForeColor = Color.FromArgb(192, 92, 31);
            LogoutLabel.ImageAlign = ContentAlignment.BottomRight;
            LogoutLabel.Location = new Point(885, 73);
            LogoutLabel.Name = "LogoutLabel";
            LogoutLabel.Size = new Size(72, 25);
            LogoutLabel.TabIndex = 5;
            LogoutLabel.Text = "Logout";
            LogoutLabel.TextAlign = ContentAlignment.MiddleCenter;
            LogoutLabel.Click += LogoutLabel_Click;
            // 
            // HomeIcon
            // 
            HomeIcon.AccessibleName = "/";
            HomeIcon.Image = (Image)resources.GetObject("HomeIcon.Image");
            HomeIcon.Location = new Point(916, 0);
            HomeIcon.Name = "HomeIcon";
            HomeIcon.Size = new Size(44, 49);
            HomeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            HomeIcon.TabIndex = 4;
            HomeIcon.TabStop = false;
            // 
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.Font = new Font("Segoe UI", 18F);
            CourseLabel.ForeColor = Color.White;
            CourseLabel.Location = new Point(396, 28);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(362, 48);
            CourseLabel.TabIndex = 3;
            CourseLabel.Text = "CSXXXX.xxx -- NAME ";
            CourseLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // UTDLogoBox
            // 
            UTDLogoBox.Image = (Image)resources.GetObject("UTDLogoBox.Image");
            UTDLogoBox.Location = new Point(0, 0);
            UTDLogoBox.Name = "UTDLogoBox";
            UTDLogoBox.Size = new Size(153, 101);
            UTDLogoBox.SizeMode = PictureBoxSizeMode.Zoom;
            UTDLogoBox.TabIndex = 0;
            UTDLogoBox.TabStop = false;
            // 
            // AttendanceButton
            // 
            AttendanceButton.BackColor = Color.White;
            AttendanceButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AttendanceButton.Location = new Point(91, 154);
            AttendanceButton.Name = "AttendanceButton";
            AttendanceButton.Size = new Size(198, 170);
            AttendanceButton.TabIndex = 2;
            AttendanceButton.Text = "Attendance";
            AttendanceButton.TextAlign = ContentAlignment.BottomCenter;
            AttendanceButton.UseVisualStyleBackColor = false;
            // 
            // PasswordButton
            // 
            PasswordButton.AccessibleDescription = "";
            PasswordButton.AccessibleName = "";
            PasswordButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordButton.Location = new Point(650, 154);
            PasswordButton.Name = "PasswordButton";
            PasswordButton.Size = new Size(198, 170);
            PasswordButton.TabIndex = 3;
            PasswordButton.Text = "Password";
            PasswordButton.TextAlign = ContentAlignment.BottomCenter;
            PasswordButton.UseVisualStyleBackColor = true;
            // 
            // QuizzesButton
            // 
            QuizzesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuizzesButton.Location = new Point(378, 154);
            QuizzesButton.Name = "QuizzesButton";
            QuizzesButton.Size = new Size(198, 170);
            QuizzesButton.TabIndex = 4;
            QuizzesButton.Text = "Quizzes";
            QuizzesButton.TextAlign = ContentAlignment.BottomCenter;
            QuizzesButton.UseVisualStyleBackColor = true;
            // 
            // EnrollmentButton
            // 
            EnrollmentButton.BackColor = Color.White;
            EnrollmentButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnrollmentButton.Location = new Point(232, 389);
            EnrollmentButton.Name = "EnrollmentButton";
            EnrollmentButton.Size = new Size(198, 170);
            EnrollmentButton.TabIndex = 5;
            EnrollmentButton.Text = "Enrollment??";
            EnrollmentButton.TextAlign = ContentAlignment.BottomCenter;
            EnrollmentButton.UseVisualStyleBackColor = false;
            // 
            // ClassDetailsButton
            // 
            ClassDetailsButton.BackColor = Color.White;
            ClassDetailsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClassDetailsButton.Location = new Point(516, 389);
            ClassDetailsButton.Name = "ClassDetailsButton";
            ClassDetailsButton.Size = new Size(198, 170);
            ClassDetailsButton.TabIndex = 6;
            ClassDetailsButton.Text = "Class Details???";
            ClassDetailsButton.TextAlign = ContentAlignment.BottomCenter;
            ClassDetailsButton.UseVisualStyleBackColor = false;
            // 
            // ClassPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(960, 600);
            Controls.Add(ClassDetailsButton);
            Controls.Add(EnrollmentButton);
            Controls.Add(QuizzesButton);
            Controls.Add(PasswordButton);
            Controls.Add(AttendanceButton);
            Controls.Add(BannerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClassPage";
            Text = "ClassPage";
            BannerPanel.ResumeLayout(false);
            BannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BannerPanel;
        private PictureBox UTDLogoBox;
        private Label CourseLabel;
        private PictureBox HomeIcon;
        private Button AttendanceButton;
        private Button PasswordButton;
        private Button QuizzesButton;
        private Label LogoutLabel;
        private Button EnrollmentButton;
        private Button ClassDetailsButton;
    }
}