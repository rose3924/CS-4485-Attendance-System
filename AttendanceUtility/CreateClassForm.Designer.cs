namespace AttendanceUtility
{
    partial class CreateClassForm
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
            CourseCreationLabel = new Label();
            LogoutLabel = new Label();
            UTDLogoBox = new PictureBox();
            CancelButton = new Button();
            SubmitButton = new Button();
            SemesterGroupBox = new GroupBox();
            DepartmentTextBox = new TextBox();
            NumberTextBox = new TextBox();
            SectionTextBox = new TextBox();
            DepartmentLabel = new Label();
            CourseNumberLabel = new Label();
            SectionLabel = new Label();
            StartTimeLabel = new Label();
            EndTimeLabel = new Label();
            StartTimePicker = new DateTimePicker();
            EndTimePicker = new DateTimePicker();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            CreditHoursLabel = new Label();
            CreditHoursTextBox = new TextBox();
            DaysGroupBox = new GroupBox();
            MondayCheckBox = new CheckBox();
            TuesdayCheckBox = new CheckBox();
            WednesdayCheckBox = new CheckBox();
            ThursdayCheckBox = new CheckBox();
            FridayCheckBox = new CheckBox();
            BannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).BeginInit();
            DaysGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // BannerPanel
            // 
            BannerPanel.BackColor = Color.FromArgb(29, 75, 54);
            BannerPanel.Controls.Add(CourseCreationLabel);
            BannerPanel.Controls.Add(LogoutLabel);
            BannerPanel.Controls.Add(UTDLogoBox);
            BannerPanel.Dock = DockStyle.Top;
            BannerPanel.Location = new Point(0, 0);
            BannerPanel.Name = "BannerPanel";
            BannerPanel.RightToLeft = RightToLeft.Yes;
            BannerPanel.Size = new Size(800, 103);
            BannerPanel.TabIndex = 1;
            // 
            // CourseCreationLabel
            // 
            CourseCreationLabel.AutoSize = true;
            CourseCreationLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseCreationLabel.ForeColor = Color.White;
            CourseCreationLabel.Location = new Point(312, 29);
            CourseCreationLabel.Name = "CourseCreationLabel";
            CourseCreationLabel.Size = new Size(228, 45);
            CourseCreationLabel.TabIndex = 4;
            CourseCreationLabel.Text = "Create Course";
            CourseCreationLabel.TextAlign = ContentAlignment.BottomLeft;
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
            // CancelButton
            // 
            CancelButton.Location = new Point(13, 108);
            CancelButton.Margin = new Padding(4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(118, 36);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(605, 401);
            SubmitButton.Margin = new Padding(4);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(182, 36);
            SubmitButton.TabIndex = 5;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // SemesterGroupBox
            // 
            SemesterGroupBox.BackColor = SystemColors.ControlLight;
            SemesterGroupBox.Location = new Point(376, 260);
            SemesterGroupBox.Name = "SemesterGroupBox";
            SemesterGroupBox.Size = new Size(183, 167);
            SemesterGroupBox.TabIndex = 6;
            SemesterGroupBox.TabStop = false;
            SemesterGroupBox.Text = "SelectSemester";
            // 
            // DepartmentTextBox
            // 
            DepartmentTextBox.CharacterCasing = CharacterCasing.Upper;
            DepartmentTextBox.Location = new Point(188, 158);
            DepartmentTextBox.MaxLength = 4;
            DepartmentTextBox.Name = "DepartmentTextBox";
            DepartmentTextBox.PlaceholderText = "ex. CS, SE";
            DepartmentTextBox.Size = new Size(113, 31);
            DepartmentTextBox.TabIndex = 7;
            // 
            // NumberTextBox
            // 
            NumberTextBox.Location = new Point(188, 210);
            NumberTextBox.MaxLength = 4;
            NumberTextBox.Name = "NumberTextBox";
            NumberTextBox.PlaceholderText = "ex. 4348";
            NumberTextBox.Size = new Size(113, 31);
            NumberTextBox.TabIndex = 8;
            // 
            // SectionTextBox
            // 
            SectionTextBox.Location = new Point(188, 270);
            SectionTextBox.MaxLength = 3;
            SectionTextBox.Name = "SectionTextBox";
            SectionTextBox.PlaceholderText = "ex. 002";
            SectionTextBox.Size = new Size(113, 31);
            SectionTextBox.TabIndex = 9;
            // 
            // DepartmentLabel
            // 
            DepartmentLabel.AutoSize = true;
            DepartmentLabel.Location = new Point(32, 164);
            DepartmentLabel.Name = "DepartmentLabel";
            DepartmentLabel.Size = new Size(107, 25);
            DepartmentLabel.TabIndex = 10;
            DepartmentLabel.Text = "Department";
            DepartmentLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // CourseNumberLabel
            // 
            CourseNumberLabel.AutoSize = true;
            CourseNumberLabel.Location = new Point(32, 216);
            CourseNumberLabel.Name = "CourseNumberLabel";
            CourseNumberLabel.Size = new Size(137, 25);
            CourseNumberLabel.TabIndex = 11;
            CourseNumberLabel.Text = "Course Number";
            // 
            // SectionLabel
            // 
            SectionLabel.AutoSize = true;
            SectionLabel.Location = new Point(32, 276);
            SectionLabel.Name = "SectionLabel";
            SectionLabel.Size = new Size(70, 25);
            SectionLabel.TabIndex = 12;
            SectionLabel.Text = "Section";
            // 
            // StartTimeLabel
            // 
            StartTimeLabel.AutoSize = true;
            StartTimeLabel.Location = new Point(32, 339);
            StartTimeLabel.Name = "StartTimeLabel";
            StartTimeLabel.Size = new Size(91, 25);
            StartTimeLabel.TabIndex = 13;
            StartTimeLabel.Text = "Start Time";
            // 
            // EndTimeLabel
            // 
            EndTimeLabel.AutoSize = true;
            EndTimeLabel.Location = new Point(32, 401);
            EndTimeLabel.Name = "EndTimeLabel";
            EndTimeLabel.Size = new Size(85, 25);
            EndTimeLabel.TabIndex = 14;
            EndTimeLabel.Text = "End Time";
            // 
            // StartTimePicker
            // 
            StartTimePicker.Cursor = Cursors.IBeam;
            StartTimePicker.CustomFormat = "hh:mm tt";
            StartTimePicker.Format = DateTimePickerFormat.Custom;
            StartTimePicker.Location = new Point(188, 333);
            StartTimePicker.Name = "StartTimePicker";
            StartTimePicker.ShowUpDown = true;
            StartTimePicker.Size = new Size(113, 31);
            StartTimePicker.TabIndex = 15;
            StartTimePicker.Value = new DateTime(2025, 4, 25, 13, 30, 0, 0);
            // 
            // EndTimePicker
            // 
            EndTimePicker.Cursor = Cursors.IBeam;
            EndTimePicker.CustomFormat = "hh:mm tt";
            EndTimePicker.Format = DateTimePickerFormat.Custom;
            EndTimePicker.Location = new Point(188, 396);
            EndTimePicker.Name = "EndTimePicker";
            EndTimePicker.ShowUpDown = true;
            EndTimePicker.Size = new Size(113, 31);
            EndTimePicker.TabIndex = 16;
            EndTimePicker.Value = new DateTime(2025, 4, 25, 14, 45, 0, 0);
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(376, 161);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(119, 25);
            NameLabel.TabIndex = 18;
            NameLabel.Text = "Course Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(532, 155);
            NameTextBox.MaxLength = 100;
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "ex. Operating Systems";
            NameTextBox.Size = new Size(244, 31);
            NameTextBox.TabIndex = 17;
            // 
            // CreditHoursLabel
            // 
            CreditHoursLabel.AutoSize = true;
            CreditHoursLabel.Location = new Point(376, 213);
            CreditHoursLabel.Name = "CreditHoursLabel";
            CreditHoursLabel.Size = new Size(112, 25);
            CreditHoursLabel.TabIndex = 20;
            CreditHoursLabel.Text = "Credit Hours";
            // 
            // CreditHoursTextBox
            // 
            CreditHoursTextBox.Location = new Point(532, 210);
            CreditHoursTextBox.MaxLength = 1;
            CreditHoursTextBox.Name = "CreditHoursTextBox";
            CreditHoursTextBox.PlaceholderText = "ex. 3";
            CreditHoursTextBox.Size = new Size(113, 31);
            CreditHoursTextBox.TabIndex = 19;
            // 
            // DaysGroupBox
            // 
            DaysGroupBox.BackColor = SystemColors.ControlLight;
            DaysGroupBox.Controls.Add(FridayCheckBox);
            DaysGroupBox.Controls.Add(ThursdayCheckBox);
            DaysGroupBox.Controls.Add(WednesdayCheckBox);
            DaysGroupBox.Controls.Add(TuesdayCheckBox);
            DaysGroupBox.Controls.Add(MondayCheckBox);
            DaysGroupBox.Location = new Point(588, 260);
            DaysGroupBox.Name = "DaysGroupBox";
            DaysGroupBox.Size = new Size(200, 117);
            DaysGroupBox.TabIndex = 21;
            DaysGroupBox.TabStop = false;
            DaysGroupBox.Text = "SelectDays";
            // 
            // MondayCheckBox
            // 
            MondayCheckBox.AutoSize = true;
            MondayCheckBox.CheckAlign = ContentAlignment.BottomCenter;
            MondayCheckBox.Location = new Point(14, 39);
            MondayCheckBox.Name = "MondayCheckBox";
            MondayCheckBox.Size = new Size(32, 50);
            MondayCheckBox.TabIndex = 0;
            MondayCheckBox.Text = "M";
            MondayCheckBox.UseVisualStyleBackColor = true;
            // 
            // TuesdayCheckBox
            // 
            TuesdayCheckBox.AutoSize = true;
            TuesdayCheckBox.CheckAlign = ContentAlignment.BottomCenter;
            TuesdayCheckBox.Location = new Point(52, 39);
            TuesdayCheckBox.Name = "TuesdayCheckBox";
            TuesdayCheckBox.Size = new Size(25, 50);
            TuesdayCheckBox.TabIndex = 1;
            TuesdayCheckBox.Text = "T";
            TuesdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // WednesdayCheckBox
            // 
            WednesdayCheckBox.AutoSize = true;
            WednesdayCheckBox.CheckAlign = ContentAlignment.BottomCenter;
            WednesdayCheckBox.Location = new Point(85, 39);
            WednesdayCheckBox.Name = "WednesdayCheckBox";
            WednesdayCheckBox.Size = new Size(33, 50);
            WednesdayCheckBox.TabIndex = 2;
            WednesdayCheckBox.Text = "W";
            WednesdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // ThursdayCheckBox
            // 
            ThursdayCheckBox.AutoSize = true;
            ThursdayCheckBox.CheckAlign = ContentAlignment.BottomCenter;
            ThursdayCheckBox.Location = new Point(122, 39);
            ThursdayCheckBox.Name = "ThursdayCheckBox";
            ThursdayCheckBox.Size = new Size(35, 50);
            ThursdayCheckBox.TabIndex = 3;
            ThursdayCheckBox.Text = "Th";
            ThursdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // FridayCheckBox
            // 
            FridayCheckBox.AutoSize = true;
            FridayCheckBox.CheckAlign = ContentAlignment.BottomCenter;
            FridayCheckBox.Location = new Point(163, 39);
            FridayCheckBox.Name = "FridayCheckBox";
            FridayCheckBox.Size = new Size(25, 50);
            FridayCheckBox.TabIndex = 4;
            FridayCheckBox.Text = "F";
            FridayCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateClassForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(DaysGroupBox);
            Controls.Add(CreditHoursLabel);
            Controls.Add(CreditHoursTextBox);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(EndTimePicker);
            Controls.Add(StartTimePicker);
            Controls.Add(EndTimeLabel);
            Controls.Add(StartTimeLabel);
            Controls.Add(SectionLabel);
            Controls.Add(CourseNumberLabel);
            Controls.Add(DepartmentLabel);
            Controls.Add(SectionTextBox);
            Controls.Add(NumberTextBox);
            Controls.Add(DepartmentTextBox);
            Controls.Add(SemesterGroupBox);
            Controls.Add(SubmitButton);
            Controls.Add(CancelButton);
            Controls.Add(BannerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateClassForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateClassForm";
            BannerPanel.ResumeLayout(false);
            BannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).EndInit();
            DaysGroupBox.ResumeLayout(false);
            DaysGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BannerPanel;
        private Label LogoutLabel;
        private PictureBox UTDLogoBox;
        private Label CourseCreationLabel;
        private Button CancelButton;
        private Button SubmitButton;
        private GroupBox SemesterGroupBox;
        private TextBox NumberTextBox;
        private TextBox SectionTextBox;
        private Label DepartmentLabel;
        private Label CourseNumberLabel;
        private Label SectionLabel;
        public TextBox DepartmentTextBox;
        private Label StartTimeLabel;
        private Label EndTimeLabel;
        private DateTimePicker StartTimePicker;
        private DateTimePicker EndTimePicker;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label CreditHoursLabel;
        public TextBox CreditHoursTextBox;
        private GroupBox DaysGroupBox;
        private CheckBox FridayCheckBox;
        private CheckBox ThursdayCheckBox;
        private CheckBox WednesdayCheckBox;
        private CheckBox TuesdayCheckBox;
        private CheckBox MondayCheckBox;
    }
}