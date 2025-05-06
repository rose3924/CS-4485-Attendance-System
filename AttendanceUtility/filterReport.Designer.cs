namespace AttendanceUtility
{
    partial class filterReport
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
            UTDLogoBox = new PictureBox();
            BannerPanel = new Panel();
            label2 = new Label();
            addStudents = new Label();
            LogoutLabel = new Label();
            fullRep = new CheckBox();
            reportFilter = new Label();
            threeAb = new CheckBox();
            cusAb = new CheckBox();
            numAb = new NumericUpDown();
            dateRange = new CheckBox();
            startDate = new DateTimePicker();
            endDate = new DateTimePicker();
            generate = new Button();
            cancel = new Button();
            gridDetails = new DataGridView();
            gridSummary = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).BeginInit();
            BannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSummary).BeginInit();
            SuspendLayout();
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
            // BannerPanel
            // 
            BannerPanel.BackColor = Color.FromArgb(29, 75, 54);
            BannerPanel.Controls.Add(label2);
            BannerPanel.Controls.Add(addStudents);
            BannerPanel.Controls.Add(LogoutLabel);
            BannerPanel.Controls.Add(UTDLogoBox);
            BannerPanel.Dock = DockStyle.Top;
            BannerPanel.Location = new Point(0, 0);
            BannerPanel.Margin = new Padding(5);
            BannerPanel.Name = "BannerPanel";
            BannerPanel.Size = new Size(1600, 169);
            BannerPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 92, 31);
            label2.ImageAlign = ContentAlignment.BottomRight;
            label2.Location = new Point(2409, 194);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(259, 41);
            label2.TabIndex = 7;
            label2.Text = "Generate Report";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addStudents
            // 
            addStudents.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addStudents.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addStudents.ForeColor = Color.FromArgb(192, 92, 31);
            addStudents.ImageAlign = ContentAlignment.BottomRight;
            addStudents.Location = new Point(2664, 194);
            addStudents.Margin = new Padding(5, 0, 5, 0);
            addStudents.Name = "addStudents";
            addStudents.Size = new Size(208, 41);
            addStudents.TabIndex = 6;
            addStudents.Text = "Add Students";
            addStudents.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogoutLabel
            // 
            LogoutLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LogoutLabel.AutoSize = true;
            LogoutLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutLabel.ForeColor = Color.FromArgb(192, 92, 31);
            LogoutLabel.ImageAlign = ContentAlignment.BottomRight;
            LogoutLabel.Location = new Point(2868, 194);
            LogoutLabel.Margin = new Padding(5, 0, 5, 0);
            LogoutLabel.Name = "LogoutLabel";
            LogoutLabel.Size = new Size(116, 41);
            LogoutLabel.TabIndex = 5;
            LogoutLabel.Text = "Logout";
            LogoutLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fullRep
            // 
            fullRep.AutoSize = true;
            fullRep.Location = new Point(109, 295);
            fullRep.Name = "fullRep";
            fullRep.Size = new Size(359, 45);
            fullRep.TabIndex = 3;
            fullRep.Text = "Full Attendance Report";
            fullRep.UseVisualStyleBackColor = true;
            fullRep.CheckedChanged += fullRep_CheckedChanged;
            // 
            // reportFilter
            // 
            reportFilter.AutoSize = true;
            reportFilter.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportFilter.ForeColor = Color.Black;
            reportFilter.Location = new Point(74, 204);
            reportFilter.Margin = new Padding(5, 0, 5, 0);
            reportFilter.Name = "reportFilter";
            reportFilter.Size = new Size(324, 62);
            reportFilter.TabIndex = 12;
            reportFilter.Text = "Report Filters";
            reportFilter.TextAlign = ContentAlignment.BottomLeft;
            // 
            // threeAb
            // 
            threeAb.AutoSize = true;
            threeAb.Location = new Point(109, 371);
            threeAb.Name = "threeAb";
            threeAb.Size = new Size(375, 45);
            threeAb.TabIndex = 13;
            threeAb.Text = "3 Consecutive Absences";
            threeAb.UseVisualStyleBackColor = true;
            threeAb.CheckedChanged += threeAb_CheckedChanged;
            // 
            // cusAb
            // 
            cusAb.AutoSize = true;
            cusAb.Location = new Point(109, 448);
            cusAb.Name = "cusAb";
            cusAb.Size = new Size(654, 45);
            cusAb.TabIndex = 14;
            cusAb.Text = "More Than                                         Absences";
            cusAb.UseVisualStyleBackColor = true;
            cusAb.CheckedChanged += cusAb_CheckedChanged;
            // 
            // numAb
            // 
            numAb.AutoSize = true;
            numAb.Location = new Point(305, 448);
            numAb.Name = "numAb";
            numAb.Size = new Size(300, 47);
            numAb.TabIndex = 15;
            numAb.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // dateRange
            // 
            dateRange.AutoSize = true;
            dateRange.Location = new Point(109, 523);
            dateRange.Name = "dateRange";
            dateRange.Size = new Size(789, 45);
            dateRange.TabIndex = 18;
            dateRange.Text = "Date Range, Start:                                                       End:";
            dateRange.UseVisualStyleBackColor = true;
            dateRange.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // startDate
            // 
            startDate.Location = new Point(407, 523);
            startDate.Name = "startDate";
            startDate.Size = new Size(400, 47);
            startDate.TabIndex = 19;
            // 
            // endDate
            // 
            endDate.Location = new Point(904, 523);
            endDate.Name = "endDate";
            endDate.Size = new Size(400, 47);
            endDate.TabIndex = 20;
            // 
            // generate
            // 
            generate.Font = new Font("Yu Gothic UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generate.Location = new Point(804, 701);
            generate.Name = "generate";
            generate.Size = new Size(248, 86);
            generate.TabIndex = 21;
            generate.Text = "Generate";
            generate.UseVisualStyleBackColor = true;
            generate.Click += generateButton_Click;
            // 
            // cancel
            // 
            cancel.Font = new Font("Yu Gothic UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel.ForeColor = Color.DarkRed;
            cancel.Location = new Point(550, 701);
            cancel.Name = "cancel";
            cancel.Size = new Size(248, 86);
            cancel.TabIndex = 22;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // gridDetails
            // 
            gridDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDetails.Location = new Point(74, 224);
            gridDetails.Name = "gridDetails";
            gridDetails.RowHeadersWidth = 102;
            gridDetails.Size = new Size(689, 415);
            gridDetails.TabIndex = 23;
            gridDetails.Visible = false;
            // 
            // gridSummary
            // 
            gridSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSummary.Location = new Point(813, 224);
            gridSummary.Name = "gridSummary";
            gridSummary.RowHeadersWidth = 102;
            gridSummary.Size = new Size(689, 415);
            gridSummary.TabIndex = 24;
            gridSummary.Visible = false;
            // 
            // filterReport
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 896);
            Controls.Add(gridSummary);
            Controls.Add(gridDetails);
            Controls.Add(cancel);
            Controls.Add(generate);
            Controls.Add(endDate);
            Controls.Add(startDate);
            Controls.Add(dateRange);
            Controls.Add(numAb);
            Controls.Add(cusAb);
            Controls.Add(threeAb);
            Controls.Add(reportFilter);
            Controls.Add(fullRep);
            Controls.Add(BannerPanel);
            Name = "filterReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "filterReport";
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).EndInit();
            BannerPanel.ResumeLayout(false);
            BannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAb).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSummary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox UTDLogoBox;
        private Panel BannerPanel;
        private Label label2;
        private Label addStudents;
        private Label LogoutLabel;
        private CheckBox fullRep;
        private Label reportFilter;
        private CheckBox threeAb;
        private CheckBox cusAb;
        private NumericUpDown numAb;
        private CheckBox dateRange;
        private DateTimePicker startDate;
        private DateTimePicker endDate;
        private Button generate;
        private Button cancel;
        private DataGridView gridDetails;
        private DataGridView gridSummary;
    }
}