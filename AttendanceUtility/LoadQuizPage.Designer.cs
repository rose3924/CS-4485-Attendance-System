namespace AttendanceUtility
{
    partial class LoadQuizPage
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
            CourseLabel = new Label();
            UTDLogoBox = new PictureBox();
            cancelButton = new Button();
            submitButton = new Button();
            quizComboBox = new ComboBox();
            actionGroupBox = new GroupBox();
            loadRadioButton = new RadioButton();
            newRadioButton = new RadioButton();
            titleLabel = new Label();
            passcodeLabel = new Label();
            titleTextBox = new TextBox();
            passcodeTextBox = new TextBox();
            validateCheckBox = new CheckBox();
            messageTextBox = new TextBox();
            BannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).BeginInit();
            actionGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // BannerPanel
            // 
            BannerPanel.BackColor = Color.FromArgb(29, 75, 54);
            BannerPanel.Controls.Add(CourseLabel);
            BannerPanel.Controls.Add(UTDLogoBox);
            BannerPanel.Dock = DockStyle.Top;
            BannerPanel.Location = new Point(0, 0);
            BannerPanel.Margin = new Padding(2);
            BannerPanel.Name = "BannerPanel";
            BannerPanel.Size = new Size(768, 82);
            BannerPanel.TabIndex = 2;
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
            UTDLogoBox.Margin = new Padding(2);
            UTDLogoBox.Name = "UTDLogoBox";
            UTDLogoBox.Size = new Size(122, 81);
            UTDLogoBox.SizeMode = PictureBoxSizeMode.Zoom;
            UTDLogoBox.TabIndex = 0;
            UTDLogoBox.TabStop = false;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(9, 87);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(109, 86);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(146, 29);
            submitButton.TabIndex = 4;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // quizComboBox
            // 
            quizComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            quizComboBox.FormattingEnabled = true;
            quizComboBox.Location = new Point(261, 86);
            quizComboBox.Name = "quizComboBox";
            quizComboBox.Size = new Size(495, 28);
            quizComboBox.TabIndex = 5;
            // 
            // actionGroupBox
            // 
            actionGroupBox.Controls.Add(loadRadioButton);
            actionGroupBox.Controls.Add(newRadioButton);
            actionGroupBox.Location = new Point(9, 146);
            actionGroupBox.Name = "actionGroupBox";
            actionGroupBox.Size = new Size(441, 69);
            actionGroupBox.TabIndex = 6;
            actionGroupBox.TabStop = false;
            actionGroupBox.Text = "Action";
            // 
            // loadRadioButton
            // 
            loadRadioButton.AutoSize = true;
            loadRadioButton.Location = new Point(231, 26);
            loadRadioButton.Name = "loadRadioButton";
            loadRadioButton.Size = new Size(152, 24);
            loadRadioButton.TabIndex = 1;
            loadRadioButton.Text = "Load Existing Quiz";
            loadRadioButton.UseVisualStyleBackColor = true;
            // 
            // newRadioButton
            // 
            newRadioButton.AutoSize = true;
            newRadioButton.Checked = true;
            newRadioButton.Location = new Point(70, 26);
            newRadioButton.Name = "newRadioButton";
            newRadioButton.Size = new Size(94, 24);
            newRadioButton.TabIndex = 0;
            newRadioButton.TabStop = true;
            newRadioButton.Text = "New Quiz";
            newRadioButton.UseVisualStyleBackColor = true;
            newRadioButton.CheckedChanged += newRadioButton_CheckedChanged;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(9, 237);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(38, 20);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Title";
            // 
            // passcodeLabel
            // 
            passcodeLabel.AutoSize = true;
            passcodeLabel.Location = new Point(381, 237);
            passcodeLabel.Name = "passcodeLabel";
            passcodeLabel.Size = new Size(69, 20);
            passcodeLabel.TabIndex = 8;
            passcodeLabel.Text = "Passcode";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(9, 260);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(364, 27);
            titleTextBox.TabIndex = 9;
            // 
            // passcodeTextBox
            // 
            passcodeTextBox.Location = new Point(379, 260);
            passcodeTextBox.Name = "passcodeTextBox";
            passcodeTextBox.Size = new Size(377, 27);
            passcodeTextBox.TabIndex = 10;
            // 
            // validateCheckBox
            // 
            validateCheckBox.AutoSize = true;
            validateCheckBox.Location = new Point(9, 304);
            validateCheckBox.Name = "validateCheckBox";
            validateCheckBox.Size = new Size(119, 24);
            validateCheckBox.TabIndex = 11;
            validateCheckBox.Text = "Validate Quiz";
            validateCheckBox.UseVisualStyleBackColor = true;
            // 
            // messageTextBox
            // 
            messageTextBox.BorderStyle = BorderStyle.None;
            messageTextBox.Location = new Point(9, 343);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.ReadOnly = true;
            messageTextBox.Size = new Size(747, 101);
            messageTextBox.TabIndex = 12;
            // 
            // LoadQuizPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 480);
            Controls.Add(messageTextBox);
            Controls.Add(validateCheckBox);
            Controls.Add(passcodeTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(passcodeLabel);
            Controls.Add(titleLabel);
            Controls.Add(actionGroupBox);
            Controls.Add(quizComboBox);
            Controls.Add(submitButton);
            Controls.Add(cancelButton);
            Controls.Add(BannerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadQuizPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadQuizPage";
            BannerPanel.ResumeLayout(false);
            BannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).EndInit();
            actionGroupBox.ResumeLayout(false);
            actionGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BannerPanel;
        private Label CourseLabel;
        private PictureBox UTDLogoBox;
        private Button cancelButton;
        private Button submitButton;
        private ComboBox quizComboBox;
        private GroupBox actionGroupBox;
        private RadioButton loadRadioButton;
        private RadioButton newRadioButton;
        private Label titleLabel;
        private Label passcodeLabel;
        private TextBox titleTextBox;
        private TextBox passcodeTextBox;
        private CheckBox validateCheckBox;
        private TextBox messageTextBox;
    }
}