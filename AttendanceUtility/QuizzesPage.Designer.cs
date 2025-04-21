namespace AttendanceUtility
{
    partial class QuizzesPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            BannerPanel = new Panel();
            LogoutLabel = new Label();
            CourseLabel = new Label();
            UTDLogoBox = new PictureBox();
            BackButtonBox = new PictureBox();
            PasswordDataGrid = new DataGridView();
            NewQuizButton = new Button();
            BannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackButtonBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PasswordDataGrid).BeginInit();
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
            BannerPanel.Margin = new Padding(2, 2, 2, 2);
            BannerPanel.Name = "BannerPanel";
            BannerPanel.Size = new Size(768, 82);
            BannerPanel.TabIndex = 1;
            // 
            // LogoutLabel
            // 
            LogoutLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LogoutLabel.AutoSize = true;
            LogoutLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutLabel.ForeColor = Color.FromArgb(192, 92, 31);
            LogoutLabel.ImageAlign = ContentAlignment.BottomRight;
            LogoutLabel.Location = new Point(708, 58);
            LogoutLabel.Margin = new Padding(2, 0, 2, 0);
            LogoutLabel.Name = "LogoutLabel";
            LogoutLabel.Size = new Size(57, 20);
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
            CourseLabel.Location = new Point(127, 22);
            CourseLabel.Margin = new Padding(2, 0, 2, 0);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(297, 37);
            CourseLabel.TabIndex = 3;
            CourseLabel.Text = "CSXXXX.xxx -- NAME ";
            CourseLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // UTDLogoBox
            // 
            UTDLogoBox.Image = Properties.Resources.utdlogo;
            UTDLogoBox.Location = new Point(0, 0);
            UTDLogoBox.Margin = new Padding(2, 2, 2, 2);
            UTDLogoBox.Name = "UTDLogoBox";
            UTDLogoBox.Size = new Size(122, 81);
            UTDLogoBox.SizeMode = PictureBoxSizeMode.Zoom;
            UTDLogoBox.TabIndex = 0;
            UTDLogoBox.TabStop = false;
            // 
            // BackButtonBox
            // 
            BackButtonBox.Image = Properties.Resources.backButton;
            BackButtonBox.Location = new Point(5, 93);
            BackButtonBox.Margin = new Padding(2, 2, 2, 2);
            BackButtonBox.Name = "BackButtonBox";
            BackButtonBox.Size = new Size(45, 30);
            BackButtonBox.SizeMode = PictureBoxSizeMode.Zoom;
            BackButtonBox.TabIndex = 7;
            BackButtonBox.TabStop = false;
            BackButtonBox.Click += BackButtonBox_Click;
            // 
            // PasswordDataGrid
            // 
            PasswordDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PasswordDataGrid.Location = new Point(36, 141);
            PasswordDataGrid.Margin = new Padding(2, 2, 2, 2);
            PasswordDataGrid.Name = "PasswordDataGrid";
            PasswordDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            PasswordDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            PasswordDataGrid.RowHeadersWidth = 62;
            PasswordDataGrid.Size = new Size(696, 320);
            PasswordDataGrid.TabIndex = 9;
            // 
            // NewQuizButton
            // 
            NewQuizButton.Location = new Point(76, 94);
            NewQuizButton.Name = "NewQuizButton";
            NewQuizButton.Size = new Size(94, 29);
            NewQuizButton.TabIndex = 10;
            NewQuizButton.Text = "New Quiz";
            NewQuizButton.UseVisualStyleBackColor = true;
            NewQuizButton.Click += NewQuizButton_Click;
            // 
            // QuizzesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(768, 480);
            Controls.Add(NewQuizButton);
            Controls.Add(PasswordDataGrid);
            Controls.Add(BackButtonBox);
            Controls.Add(BannerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "QuizzesPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuizzesPage";
            BannerPanel.ResumeLayout(false);
            BannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackButtonBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PasswordDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BannerPanel;
        private PictureBox UTDLogoBox;
        private Label CourseLabel;
        private Label LogoutLabel;
        private PictureBox BackButtonBox;
        private DataGridView PasswordDataGrid;
        private Button NewQuizButton;
    }
}