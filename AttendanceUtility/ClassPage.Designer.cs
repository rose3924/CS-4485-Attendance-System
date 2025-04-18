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
            BannerPanel = new Panel();
            LogoutLabel = new Label();
            CourseLabel = new Label();
            UTDLogoBox = new PictureBox();
            AttendanceButton = new Button();
            PasswordButton = new Button();
            QuizzesButton = new Button();
            BackButtonBox = new PictureBox();
            BannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackButtonBox).BeginInit();
            SuspendLayout();
            // 
            // BannerPanel
            // 
            BannerPanel.BackColor = Color.FromArgb(29, 75, 54);
            BannerPanel.Controls.Add(LogoutLabel);
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
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseLabel.ForeColor = Color.White;
            CourseLabel.Location = new Point(159, 27);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(355, 45);
            CourseLabel.TabIndex = 3;
            CourseLabel.Text = "CSXXXX.xxx -- NAME ";
            CourseLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // UTDLogoBox
            // 
            UTDLogoBox.Image = Properties.Resources.utdlogo;
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
            AttendanceButton.Image = Properties.Resources.user_check;
            AttendanceButton.Location = new Point(91, 240);
            AttendanceButton.Name = "AttendanceButton";
            AttendanceButton.Size = new Size(198, 170);
            AttendanceButton.TabIndex = 2;
            AttendanceButton.Text = "Attendance";
            AttendanceButton.TextAlign = ContentAlignment.BottomCenter;
            AttendanceButton.UseVisualStyleBackColor = false;
            AttendanceButton.Click += AttendanceButton_Click;
            // 
            // PasswordButton
            // 
            PasswordButton.AccessibleDescription = "";
            PasswordButton.AccessibleName = "";
            PasswordButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordButton.Image = Properties.Resources.lock__1_;
            PasswordButton.Location = new Point(650, 240);
            PasswordButton.Name = "PasswordButton";
            PasswordButton.Size = new Size(198, 170);
            PasswordButton.TabIndex = 3;
            PasswordButton.Text = "Password";
            PasswordButton.TextAlign = ContentAlignment.BottomCenter;
            PasswordButton.UseVisualStyleBackColor = true;
            PasswordButton.Click += PasswordButton_Click;
            // 
            // QuizzesButton
            // 
            QuizzesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuizzesButton.Image = Properties.Resources.quiz;
            QuizzesButton.Location = new Point(378, 240);
            QuizzesButton.Name = "QuizzesButton";
            QuizzesButton.Size = new Size(198, 170);
            QuizzesButton.TabIndex = 4;
            QuizzesButton.Text = "Quizzes";
            QuizzesButton.TextAlign = ContentAlignment.BottomCenter;
            QuizzesButton.UseVisualStyleBackColor = true;
            QuizzesButton.Click += QuizzesButton_Click;
            // 
            // BackButtonBox
            // 
            BackButtonBox.Image = Properties.Resources.backButton;
            BackButtonBox.Location = new Point(6, 116);
            BackButtonBox.Name = "BackButtonBox";
            BackButtonBox.Size = new Size(56, 37);
            BackButtonBox.SizeMode = PictureBoxSizeMode.Zoom;
            BackButtonBox.TabIndex = 7;
            BackButtonBox.TabStop = false;
            BackButtonBox.Click += BackButtonBox_Click;
            // 
            // ClassPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(960, 600);
            Controls.Add(BackButtonBox);
            Controls.Add(QuizzesButton);
            Controls.Add(PasswordButton);
            Controls.Add(AttendanceButton);
            Controls.Add(BannerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClassPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClassPage";
            BannerPanel.ResumeLayout(false);
            BannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackButtonBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BannerPanel;
        private PictureBox UTDLogoBox;
        private Label CourseLabel;
        private Button AttendanceButton;
        private Button PasswordButton;
        private Button QuizzesButton;
        private Label LogoutLabel;
        private PictureBox BackButtonBox;
    }
}