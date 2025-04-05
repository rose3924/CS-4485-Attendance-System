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
            ClassesHomeLayoutPanel = new FlowLayoutPanel();
            BannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).BeginInit();
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
            CourseLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CourseLabel.ForeColor = Color.White;
            CourseLabel.Location = new Point(349, 27);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(171, 48);
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
            // ClassesHomeLayoutPanel
            // 
            ClassesHomeLayoutPanel.AutoScroll = true;
            ClassesHomeLayoutPanel.Dock = DockStyle.Bottom;
            ClassesHomeLayoutPanel.Location = new Point(0, 103);
            ClassesHomeLayoutPanel.Name = "ClassesHomeLayoutPanel";
            ClassesHomeLayoutPanel.Size = new Size(960, 497);
            ClassesHomeLayoutPanel.TabIndex = 1;
            // 
            // ClassesHomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 600);
            Controls.Add(ClassesHomeLayoutPanel);
            Controls.Add(BannerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClassesHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClassesHomePage";
            BannerPanel.ResumeLayout(false);
            BannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BannerPanel;
        private PictureBox UTDLogoBox;
        private Label LogoutLabel;
        private Label CourseLabel;
        private FlowLayoutPanel ClassesHomeLayoutPanel;
    }
}