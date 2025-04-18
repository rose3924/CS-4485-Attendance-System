namespace AttendanceUtility
{
    partial class PasswordPage
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
            // PasswordDataGrid
            // 
            PasswordDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PasswordDataGrid.Location = new Point(45, 176);
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
            PasswordDataGrid.Size = new Size(870, 400);
            PasswordDataGrid.TabIndex = 8;
            // 
            // PasswordPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(960, 600);
            Controls.Add(PasswordDataGrid);
            Controls.Add(BackButtonBox);
            Controls.Add(BannerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PasswordPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PasswordPage";
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
    }
}