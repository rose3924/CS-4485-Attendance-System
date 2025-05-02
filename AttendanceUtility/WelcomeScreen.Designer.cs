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
            BannerPanel = new Panel();
            LogoutLabel = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            welcomeProgressBar = new ProgressBar();
            BannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BannerPanel
            // 
            BannerPanel.BackColor = Color.FromArgb(29, 75, 54);
            BannerPanel.Controls.Add(LogoutLabel);
            BannerPanel.Dock = DockStyle.Top;
            BannerPanel.Location = new Point(0, 0);
            BannerPanel.Margin = new Padding(2);
            BannerPanel.Name = "BannerPanel";
            BannerPanel.Size = new Size(672, 62);
            BannerPanel.TabIndex = 4;
            // 
            // LogoutLabel
            // 
            LogoutLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LogoutLabel.AutoSize = true;
            LogoutLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutLabel.ForeColor = Color.FromArgb(192, 92, 31);
            LogoutLabel.ImageAlign = ContentAlignment.BottomRight;
            LogoutLabel.Location = new Point(1092, -30);
            LogoutLabel.Margin = new Padding(2, 0, 2, 0);
            LogoutLabel.Name = "LogoutLabel";
            LogoutLabel.Size = new Size(45, 15);
            LogoutLabel.TabIndex = 5;
            LogoutLabel.Text = "Logout";
            LogoutLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.utdlogo;
            pictureBox1.Location = new Point(225, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Microsoft Sans Serif", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(101, 210);
            label2.Name = "label2";
            label2.Size = new Size(482, 39);
            label2.TabIndex = 6;
            label2.Text = "Welcome to UTD Attendance";
            // 
            // welcomeProgressBar
            // 
            welcomeProgressBar.BackColor = Color.WhiteSmoke;
            welcomeProgressBar.Location = new Point(101, 267);
            welcomeProgressBar.Name = "welcomeProgressBar";
            welcomeProgressBar.Size = new Size(482, 17);
            welcomeProgressBar.Style = ProgressBarStyle.Marquee;
            welcomeProgressBar.TabIndex = 7;
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(672, 360);
            Controls.Add(welcomeProgressBar);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(BannerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "WelcomeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WelcomeScreen";
            Load += WelcomeScreen_Load;
            BannerPanel.ResumeLayout(false);
            BannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel BannerPanel;
        private Label LogoutLabel;
        private PictureBox pictureBox1;
        private Label label2;
        private ProgressBar welcomeProgressBar;
    }
}
