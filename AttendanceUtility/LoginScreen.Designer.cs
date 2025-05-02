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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            BannerPanel = new Panel();
            ExitLabel = new Label();
            UTDLogoBox = new PictureBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            labelError = new Label();
            labelPassword = new Label();
            labelID = new Label();
            textBoxPassword = new TextBox();
            textBoxID = new TextBox();
            buttonLogin = new Button();
            pictureBoxWarning = new PictureBox();
            BannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWarning).BeginInit();
            SuspendLayout();
            // 
            // BannerPanel
            // 
            BannerPanel.BackColor = Color.FromArgb(29, 75, 54);
            BannerPanel.Controls.Add(ExitLabel);
            BannerPanel.Controls.Add(UTDLogoBox);
            BannerPanel.Dock = DockStyle.Top;
            BannerPanel.Location = new Point(0, 0);
            BannerPanel.Margin = new Padding(2, 3, 2, 3);
            BannerPanel.Name = "BannerPanel";
            BannerPanel.RightToLeft = RightToLeft.Yes;
            BannerPanel.Size = new Size(768, 83);
            BannerPanel.TabIndex = 0;
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitLabel.ForeColor = Color.FromArgb(192, 92, 31);
            ExitLabel.Location = new Point(713, 61);
            ExitLabel.Margin = new Padding(2, 0, 2, 0);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(35, 20);
            ExitLabel.TabIndex = 5;
            ExitLabel.Text = "Exit";
            ExitLabel.Click += ExitLabel_Click;
            // 
            // UTDLogoBox
            // 
            UTDLogoBox.Image = Properties.Resources.utdlogo;
            UTDLogoBox.Location = new Point(0, 0);
            UTDLogoBox.Margin = new Padding(2, 3, 2, 3);
            UTDLogoBox.Name = "UTDLogoBox";
            UTDLogoBox.Size = new Size(122, 81);
            UTDLogoBox.SizeMode = PictureBoxSizeMode.Zoom;
            UTDLogoBox.TabIndex = 0;
            UTDLogoBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelError);
            groupBox1.Controls.Add(labelPassword);
            groupBox1.Controls.Add(labelID);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(textBoxID);
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Controls.Add(pictureBoxWarning);
            groupBox1.Location = new Point(86, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(592, 367);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(115, 31);
            label1.Name = "label1";
            label1.Size = new Size(391, 36);
            label1.TabIndex = 9;
            label1.Text = "Welcome to myAttendance";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(242, 251);
            labelError.Name = "labelError";
            labelError.Size = new Size(166, 16);
            labelError.TabIndex = 8;
            labelError.Text = "Invalid ID or Password!";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(43, 177);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(113, 25);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Password:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelID.Location = new Point(43, 97);
            labelID.Name = "labelID";
            labelID.Size = new Size(99, 25);
            labelID.TabIndex = 6;
            labelID.Text = "Login ID:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(242, 173);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(297, 30);
            textBoxPassword.TabIndex = 4;
            // 
            // textBoxID
            // 
            textBoxID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxID.Location = new Point(242, 93);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(297, 30);
            textBoxID.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(255, 128, 0);
            buttonLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(242, 299);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(130, 45);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += LoginButton_Click;
            // 
            // pictureBoxWarning
            // 
            pictureBoxWarning.Image = (Image)resources.GetObject("pictureBoxWarning.Image");
            pictureBoxWarning.Location = new Point(184, 237);
            pictureBoxWarning.Name = "pictureBoxWarning";
            pictureBoxWarning.Size = new Size(34, 31);
            pictureBoxWarning.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxWarning.TabIndex = 2;
            pictureBoxWarning.TabStop = false;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 480);
            Controls.Add(groupBox1);
            Controls.Add(BannerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginScreen";
            BannerPanel.ResumeLayout(false);
            BannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWarning).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BannerPanel;
        private PictureBox UTDLogoBox;
        private GroupBox groupBox1;
        private Label label1;
        private Label labelError;
        private Label labelPassword;
        private Label labelID;
        private TextBox textBoxPassword;
        private TextBox textBoxID;
        private Button buttonLogin;
        private PictureBox pictureBoxWarning;
        private Label ExitLabel;
    }
}