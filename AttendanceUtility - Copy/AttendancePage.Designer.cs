namespace AttendanceUtility
{
    partial class AttendancePage
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
            BackButtonBox = new PictureBox();
            csvUpload = new Button();
            AttendanceDataGrid = new DataGridView();
            button1 = new Button();
            filterCSV = new ComboBox();
            filter = new Label();
            userFilepath = new TextBox();
            BannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackButtonBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AttendanceDataGrid).BeginInit();
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
            BannerPanel.Margin = new Padding(5);
            BannerPanel.Name = "BannerPanel";
            BannerPanel.Size = new Size(1632, 169);
            BannerPanel.TabIndex = 1;
            // 
            // LogoutLabel
            // 
            LogoutLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LogoutLabel.AutoSize = true;
            LogoutLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutLabel.ForeColor = Color.FromArgb(192, 92, 31);
            LogoutLabel.ImageAlign = ContentAlignment.BottomRight;
            LogoutLabel.Location = new Point(1504, 120);
            LogoutLabel.Margin = new Padding(5, 0, 5, 0);
            LogoutLabel.Name = "LogoutLabel";
            LogoutLabel.Size = new Size(116, 41);
            LogoutLabel.TabIndex = 5;
            LogoutLabel.Text = "Logout";
            LogoutLabel.TextAlign = ContentAlignment.MiddleCenter;
            LogoutLabel.Click += LogoutLabel_Click;
            // 
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.Font = new Font("Segoe UI", 18F);
            CourseLabel.ForeColor = Color.White;
            CourseLabel.Location = new Point(673, 46);
            CourseLabel.Margin = new Padding(5, 0, 5, 0);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(605, 81);
            CourseLabel.TabIndex = 3;
            CourseLabel.Text = "CSXXXX.xxx -- NAME ";
            CourseLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // UTDLogoBox
            // 
            UTDLogoBox.Image = Properties.Resources.utdlogo;
            UTDLogoBox.Location = new Point(0, 0);
            UTDLogoBox.Margin = new Padding(5);
            UTDLogoBox.Name = "UTDLogoBox";
            UTDLogoBox.Size = new Size(260, 166);
            UTDLogoBox.SizeMode = PictureBoxSizeMode.Zoom;
            UTDLogoBox.TabIndex = 0;
            UTDLogoBox.TabStop = false;
            // 
            // BackButtonBox
            // 
            BackButtonBox.Image = Properties.Resources.backButton;
            BackButtonBox.Location = new Point(10, 190);
            BackButtonBox.Margin = new Padding(5);
            BackButtonBox.Name = "BackButtonBox";
            BackButtonBox.Size = new Size(95, 61);
            BackButtonBox.SizeMode = PictureBoxSizeMode.Zoom;
            BackButtonBox.TabIndex = 7;
            BackButtonBox.TabStop = false;
            BackButtonBox.Click += BackButtonBox_Click;
            // 
            // csvUpload
            // 
            csvUpload.Location = new Point(1383, 183);
            csvUpload.Margin = new Padding(5);
            csvUpload.Name = "csvUpload";
            csvUpload.Size = new Size(197, 89);
            csvUpload.TabIndex = 8;
            csvUpload.Text = "Upload CSV";
            csvUpload.UseVisualStyleBackColor = true;
            csvUpload.Click += CSVButton_Click;
            // 
            // AttendanceDataGrid
            // 
            AttendanceDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendanceDataGrid.Location = new Point(76, 289);
            AttendanceDataGrid.Margin = new Padding(5);
            AttendanceDataGrid.Name = "AttendanceDataGrid";
            AttendanceDataGrid.RowHeadersWidth = 62;
            AttendanceDataGrid.Size = new Size(1479, 656);
            AttendanceDataGrid.TabIndex = 9;
            AttendanceDataGrid.CellContentClick += AttendanceDataGrid_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(1165, 183);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(197, 89);
            button1.TabIndex = 10;
            button1.Text = "Browse CSVs";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // filterCSV
            // 
            filterCSV.DropDownStyle = ComboBoxStyle.DropDownList;
            filterCSV.FormattingEnabled = true;
            filterCSV.Items.AddRange(new object[] { "More Than 3 Consecutive Absences ", "More Than _____ Total Absences " });
            filterCSV.Location = new Point(277, 202);
            filterCSV.Name = "filterCSV";
            filterCSV.Size = new Size(302, 49);
            filterCSV.TabIndex = 11;
            filterCSV.SelectedIndexChanged += filterCSV_SelectedIndexChanged;
            // 
            // filter
            // 
            filter.AutoSize = true;
            filter.Location = new Point(188, 202);
            filter.Name = "filter";
            filter.Size = new Size(83, 41);
            filter.TabIndex = 12;
            filter.Text = "Filter";
            filter.Click += label1_Click;
            // 
            // userFilepath
            // 
            userFilepath.AcceptsReturn = true;
            userFilepath.Location = new Point(652, 494);
            userFilepath.Name = "userFilepath";
            userFilepath.Size = new Size(250, 47);
            userFilepath.TabIndex = 13;
            userFilepath.Text = "Enter File Path...";
            userFilepath.Visible = false;
            userFilepath.TextChanged += userFilepath_TextChanged;
            userFilepath.KeyDown += userFilepath_KeyDown;
            // 
            // AttendancePage
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1632, 984);
            Controls.Add(userFilepath);
            Controls.Add(filter);
            Controls.Add(filterCSV);
            Controls.Add(button1);
            Controls.Add(AttendanceDataGrid);
            Controls.Add(csvUpload);
            Controls.Add(BackButtonBox);
            Controls.Add(BannerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "AttendancePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AttendancePage";
            BannerPanel.ResumeLayout(false);
            BannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackButtonBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AttendanceDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BannerPanel;
        private PictureBox UTDLogoBox;
        private Label CourseLabel;
        private Label LogoutLabel;
        private PictureBox BackButtonBox;
        private Button CSVButton;
        private DataGridView AttendanceDataGrid;
        private Button button1;
        private ComboBox filterCSV;
        private Label filter;
        private Button csvUpload;
        private TextBox userFilepath;
    }
}
