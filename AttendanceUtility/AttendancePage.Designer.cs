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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendancePage));
            BackButtonBox = new PictureBox();
            filterCSV = new ComboBox();
            filter = new Label();
            monthCalendar1 = new MonthCalendar();
            UTDLogoBox = new PictureBox();
            CourseLabel = new Label();
            LogoutLabel = new Label();
            BannerPanel = new Panel();
            label2 = new Label();
            addStudents = new Label();
            panel1 = new Panel();
            TodayButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            attendecneDataGrid = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)BackButtonBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).BeginInit();
            BannerPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)attendecneDataGrid).BeginInit();
            SuspendLayout();
            // 
            // BackButtonBox
            // 
            BackButtonBox.Image = (Image)resources.GetObject("BackButtonBox.Image");
            BackButtonBox.Location = new Point(18, 13);
            BackButtonBox.Margin = new Padding(5);
            BackButtonBox.Name = "BackButtonBox";
            BackButtonBox.Size = new Size(124, 84);
            BackButtonBox.SizeMode = PictureBoxSizeMode.Zoom;
            BackButtonBox.TabIndex = 7;
            BackButtonBox.TabStop = false;
            BackButtonBox.Click += BackButtonBox_Click;
            // 
            // filterCSV
            // 
            filterCSV.DropDownStyle = ComboBoxStyle.DropDownList;
            filterCSV.FormattingEnabled = true;
            filterCSV.Items.AddRange(new object[] { "More Than 3 Consecutive Absences ", "More Than _____ Total Absences " });
            filterCSV.Location = new Point(52, 627);
            filterCSV.Name = "filterCSV";
            filterCSV.Size = new Size(302, 49);
            filterCSV.TabIndex = 11;
            filterCSV.SelectedIndexChanged += filterCSV_SelectedIndexChanged;
            // 
            // filter
            // 
            filter.AutoSize = true;
            filter.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filter.ForeColor = SystemColors.ButtonHighlight;
            filter.Location = new Point(52, 566);
            filter.Name = "filter";
            filter.Size = new Size(112, 50);
            filter.TabIndex = 12;
            filter.Text = "Filter";
            filter.Click += label1_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 117);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 13;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
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
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseLabel.ForeColor = Color.White;
            CourseLabel.Location = new Point(270, 44);
            CourseLabel.Margin = new Padding(5, 0, 5, 0);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(592, 72);
            CourseLabel.TabIndex = 3;
            CourseLabel.Text = "CSXXXX.xxx -- NAME ";
            CourseLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // LogoutLabel
            // 
            LogoutLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LogoutLabel.AutoSize = true;
            LogoutLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutLabel.ForeColor = Color.FromArgb(192, 92, 31);
            LogoutLabel.ImageAlign = ContentAlignment.BottomRight;
            LogoutLabel.Location = new Point(1468, 125);
            LogoutLabel.Margin = new Padding(5, 0, 5, 0);
            LogoutLabel.Name = "LogoutLabel";
            LogoutLabel.Size = new Size(116, 41);
            LogoutLabel.TabIndex = 5;
            LogoutLabel.Text = "Logout";
            LogoutLabel.TextAlign = ContentAlignment.MiddleCenter;
            LogoutLabel.Click += LogoutLabel_Click;
            // 
            // BannerPanel
            // 
            BannerPanel.BackColor = Color.FromArgb(29, 75, 54);
            BannerPanel.Controls.Add(label2);
            BannerPanel.Controls.Add(addStudents);
            BannerPanel.Controls.Add(LogoutLabel);
            BannerPanel.Controls.Add(CourseLabel);
            BannerPanel.Controls.Add(UTDLogoBox);
            BannerPanel.Dock = DockStyle.Top;
            BannerPanel.Location = new Point(0, 0);
            BannerPanel.Margin = new Padding(5);
            BannerPanel.Name = "BannerPanel";
            BannerPanel.Size = new Size(1589, 169);
            BannerPanel.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 92, 31);
            label2.ImageAlign = ContentAlignment.BottomRight;
            label2.Location = new Point(1009, 125);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(259, 41);
            label2.TabIndex = 7;
            label2.Text = "Generate Report";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click_1;
            // 
            // addStudents
            // 
            addStudents.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addStudents.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addStudents.ForeColor = Color.FromArgb(192, 92, 31);
            addStudents.ImageAlign = ContentAlignment.BottomRight;
            addStudents.Location = new Point(1264, 125);
            addStudents.Margin = new Padding(5, 0, 5, 0);
            addStudents.Name = "addStudents";
            addStudents.Size = new Size(208, 41);
            addStudents.TabIndex = 6;
            addStudents.Text = "Add Students";
            addStudents.TextAlign = ContentAlignment.MiddleCenter;
            addStudents.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 75, 54);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(filter);
            panel1.Controls.Add(filterCSV);
            panel1.Controls.Add(BackButtonBox);
            panel1.Location = new Point(0, 165);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 823);
            panel1.TabIndex = 14;
            // 
            // TodayButton
            // 
            TodayButton.Font = new Font("Yu Gothic UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TodayButton.Location = new Point(559, 191);
            TodayButton.Name = "TodayButton";
            TodayButton.Size = new Size(248, 86);
            TodayButton.TabIndex = 15;
            TodayButton.Text = "Today";
            TodayButton.UseVisualStyleBackColor = true;
            TodayButton.Click += TodayButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.right_arrow_3094;
            pictureBox1.Location = new Point(902, 191);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(810, 191);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(994, 200);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(335, 62);
            label1.TabIndex = 11;
            label1.Text = "April 23, 2025";
            label1.TextAlign = ContentAlignment.BottomLeft;
            label1.Click += label1_Click_1;
            // 
            // attendecneDataGrid
            // 
            attendecneDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendecneDataGrid.Location = new Point(569, 312);
            attendecneDataGrid.Name = "attendecneDataGrid";
            attendecneDataGrid.RowHeadersWidth = 102;
            attendecneDataGrid.Size = new Size(1010, 642);
            attendecneDataGrid.TabIndex = 19;
            attendecneDataGrid.CellValueChanged += attendecneDataGrid_CellValueChanged;
            // 
            // timer1
            // 
            timer1.Tick += currentDate_Tick;
            // 
            // AttendancePage
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1632, 984);
            Controls.Add(attendecneDataGrid);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(TodayButton);
            Controls.Add(panel1);
            Controls.Add(BannerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "AttendancePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AttendancePage";
            Load += AttendancePage_Load;
            ((System.ComponentModel.ISupportInitialize)BackButtonBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).EndInit();
            BannerPanel.ResumeLayout(false);
            BannerPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)attendecneDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox BackButtonBox;
        private Button CSVButton;
        private ComboBox filterCSV;
        private Label filter;
        private MonthCalendar monthCalendar1;
        private PictureBox UTDLogoBox;
        private Label CourseLabel;
        private Label LogoutLabel;
        private Panel BannerPanel;
        private Panel panel1;
        private Button TodayButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private DataGridView attendecneDataGrid;
        private System.Windows.Forms.Timer timer1;
        private Label addStudents;
        private Label label2;
    }
}
