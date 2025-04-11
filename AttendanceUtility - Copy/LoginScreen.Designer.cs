namespace AttendanceUtility
{
    partial class LoginScreen
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
            UTDLogoBox = new PictureBox();
            LoginButton = new Button();
            BannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).BeginInit();
            SuspendLayout();
            // 
            // BannerPanel
            // 
            BannerPanel.BackColor = Color.FromArgb(29, 75, 54);
            BannerPanel.Controls.Add(UTDLogoBox);
            BannerPanel.Dock = DockStyle.Top;
            BannerPanel.Location = new Point(0, 0);
            BannerPanel.Name = "BannerPanel";
            BannerPanel.RightToLeft = RightToLeft.Yes;
            BannerPanel.Size = new Size(960, 103);
            BannerPanel.TabIndex = 0;
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
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.Location = new Point(303, 432);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(334, 72);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 600);
            Controls.Add(LoginButton);
            Controls.Add(BannerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginScreen";
            BannerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BannerPanel;
        private PictureBox UTDLogoBox;
        private Button LoginButton;
    }
}