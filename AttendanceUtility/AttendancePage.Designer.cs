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
            // csvUpload
            // 
            csvUpload.Location = new Point(814, 112);
            csvUpload.Name = "csvUpload";
            csvUpload.Size = new Size(116, 54);
            csvUpload.TabIndex = 8;
            csvUpload.Text = "Upload CSV";
            csvUpload.UseVisualStyleBackColor = true;
            csvUpload.Click += CSVButton_Click;
            // 
            // AttendanceDataGrid
            // 
            AttendanceDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendanceDataGrid.Location = new Point(45, 176);
            AttendanceDataGrid.Name = "AttendanceDataGrid";
            AttendanceDataGrid.RowHeadersWidth = 62;
            AttendanceDataGrid.Size = new Size(870, 400);
            AttendanceDataGrid.TabIndex = 9;
            AttendanceDataGrid.CellContentClick += AttendanceDataGrid_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(685, 112);
            button1.Name = "button1";
            button1.Size = new Size(116, 54);
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
            filterCSV.Location = new Point(163, 123);
            filterCSV.Margin = new Padding(2, 2, 2, 2);
            filterCSV.Name = "filterCSV";
            filterCSV.Size = new Size(179, 33);
            filterCSV.TabIndex = 11;
            filterCSV.SelectedIndexChanged += filterCSV_SelectedIndexChanged;
            // 
            // filter
            // 
            filter.AutoSize = true;
            filter.Location = new Point(111, 123);
            filter.Margin = new Padding(2, 0, 2, 0);
            filter.Name = "filter";
            filter.Size = new Size(50, 25);
            filter.TabIndex = 12;
            filter.Text = "Filter";
            filter.Click += label1_Click;
            // 
            // userFilepath
            // 
            userFilepath.AcceptsReturn = true;
            userFilepath.Location = new Point(384, 301);
            userFilepath.Margin = new Padding(2, 2, 2, 2);
            userFilepath.Name = "userFilepath";
            userFilepath.Size = new Size(149, 31);
            userFilepath.TabIndex = 13;
            userFilepath.Text = "Enter File Path...";
            userFilepath.Visible = false;
            userFilepath.TextChanged += userFilepath_TextChanged;
            userFilepath.KeyDown += userFilepath_KeyDown;
            // 
            // AttendancePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(960, 600);
            Controls.Add(userFilepath);
            Controls.Add(filter);
            Controls.Add(filterCSV);
            Controls.Add(button1);
            Controls.Add(AttendanceDataGrid);
            Controls.Add(csvUpload);
            Controls.Add(BackButtonBox);
            Controls.Add(BannerPanel);
            FormBorderStyle = FormBorderStyle.None;
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
