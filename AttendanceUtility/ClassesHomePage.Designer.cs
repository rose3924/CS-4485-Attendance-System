namespace AttendanceUtility
{
    partial class ClassesHomePage
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
            CourseLabel = new Label();
            LogoutLabel = new Label();
            UTDLogoBox = new PictureBox();
            ProfNameLabel = new Label();
            ClassesHomeLayoutPanel = new FlowLayoutPanel();
            NoCoursesMessageLabel = new Label();
            SemesterComboBox = new ComboBox();
            BannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).BeginInit();
            ClassesHomeLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BannerPanel
            // 
            BannerPanel.BackColor = Color.FromArgb(29, 75, 54);
            BannerPanel.Controls.Add(CourseLabel);
            BannerPanel.Controls.Add(LogoutLabel);
            BannerPanel.Controls.Add(UTDLogoBox);
            BannerPanel.Dock = DockStyle.Top;
            BannerPanel.Location = new Point(0, 0);
            BannerPanel.Name = "BannerPanel";
            BannerPanel.RightToLeft = RightToLeft.Yes;
            BannerPanel.Size = new Size(960, 103);
            BannerPanel.TabIndex = 0;
            // 
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseLabel.ForeColor = Color.White;
            CourseLabel.Location = new Point(358, 27);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(178, 48);
            CourseLabel.TabIndex = 2;
            CourseLabel.Text = "COURSES";
            // 
            // LogoutLabel
            // 
            LogoutLabel.AutoSize = true;
            LogoutLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutLabel.ForeColor = Color.FromArgb(192, 92, 31);
            LogoutLabel.Location = new Point(885, 73);
            LogoutLabel.Name = "LogoutLabel";
            LogoutLabel.Size = new Size(72, 25);
            LogoutLabel.TabIndex = 1;
            LogoutLabel.Text = "Logout";
            LogoutLabel.Click += LogoutLabel_Click;
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
            // ProfNameLabel
            // 
            ProfNameLabel.AutoSize = true;
            ProfNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ProfNameLabel.ForeColor = Color.Black;
            ProfNameLabel.Location = new Point(587, 108);
            ProfNameLabel.Name = "ProfNameLabel";
            ProfNameLabel.Size = new Size(171, 25);
            ProfNameLabel.TabIndex = 3;
            ProfNameLabel.Text = "Welcome, Professor";
            // 
            // ClassesHomeLayoutPanel
            // 
            ClassesHomeLayoutPanel.AutoScroll = true;
            ClassesHomeLayoutPanel.Controls.Add(NoCoursesMessageLabel);
            ClassesHomeLayoutPanel.Dock = DockStyle.Bottom;
            ClassesHomeLayoutPanel.FlowDirection = FlowDirection.TopDown;
            ClassesHomeLayoutPanel.Location = new Point(0, 140);
            ClassesHomeLayoutPanel.Name = "ClassesHomeLayoutPanel";
            ClassesHomeLayoutPanel.Size = new Size(960, 460);
            ClassesHomeLayoutPanel.TabIndex = 1;
            ClassesHomeLayoutPanel.WrapContents = false;
            // 
            // NoCoursesMessageLabel
            // 
            NoCoursesMessageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            NoCoursesMessageLabel.ForeColor = SystemColors.ButtonShadow;
            NoCoursesMessageLabel.ImageAlign = ContentAlignment.MiddleLeft;
            NoCoursesMessageLabel.Location = new Point(3, 0);
            NoCoursesMessageLabel.Name = "NoCoursesMessageLabel";
            NoCoursesMessageLabel.Size = new Size(945, 460);
            NoCoursesMessageLabel.TabIndex = 1;
            NoCoursesMessageLabel.Text = "No Courses to Display";
            NoCoursesMessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SemesterComboBox
            // 
            SemesterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SemesterComboBox.FormattingEnabled = true;
            SemesterComboBox.Location = new Point(2, 105);
            SemesterComboBox.Name = "SemesterComboBox";
            SemesterComboBox.Size = new Size(180, 33);
            SemesterComboBox.TabIndex = 0;
            SemesterComboBox.SelectedIndexChanged += SemesterComboBox_SelectedIndexChanged;
            // 
            // ClassesHomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 600);
            Controls.Add(ProfNameLabel);
            Controls.Add(SemesterComboBox);
            Controls.Add(ClassesHomeLayoutPanel);
            Controls.Add(BannerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClassesHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClassesHomePage";
            BannerPanel.ResumeLayout(false);
            BannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).EndInit();
            ClassesHomeLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BannerPanel;
        private PictureBox UTDLogoBox;
        private Label LogoutLabel;
        private Label CourseLabel;
        private FlowLayoutPanel ClassesHomeLayoutPanel;
        private ComboBox SemesterComboBox;
        private Label NoCoursesMessageLabel;
        private Label ProfNameLabel;
    }
}