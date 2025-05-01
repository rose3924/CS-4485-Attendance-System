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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            BannerPanel = new Panel();
            LogoutLabel = new Label();
            CourseLabel = new Label();
            UTDLogoBox = new PictureBox();
            BackButtonBox = new PictureBox();
            questionDataGridView = new DataGridView();
            NewQuizButton = new Button();
            saveButton = new Button();
            quiztitleTextBox = new TextBox();
            passcodeTextBox = new TextBox();
            validateLabel = new Label();
            answersDataGridView = new DataGridView();
            questionContextMenuStrip = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            addExistingQuestionToolStripMenuItem = new ToolStripMenuItem();
            BannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackButtonBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)questionDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)answersDataGridView).BeginInit();
            questionContextMenuStrip.SuspendLayout();
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
            BannerPanel.Margin = new Padding(2);
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
            UTDLogoBox.Margin = new Padding(2);
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
            BackButtonBox.Margin = new Padding(2);
            BackButtonBox.Name = "BackButtonBox";
            BackButtonBox.Size = new Size(45, 30);
            BackButtonBox.SizeMode = PictureBoxSizeMode.Zoom;
            BackButtonBox.TabIndex = 7;
            BackButtonBox.TabStop = false;
            BackButtonBox.Click += BackButtonBox_Click;
            // 
            // questionDataGridView
            // 
            questionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionDataGridView.Location = new Point(11, 141);
            questionDataGridView.Margin = new Padding(2);
            questionDataGridView.MultiSelect = false;
            questionDataGridView.Name = "questionDataGridView";
            questionDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            questionDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            questionDataGridView.RowHeadersWidth = 62;
            questionDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            questionDataGridView.Size = new Size(746, 150);
            questionDataGridView.TabIndex = 9;
            questionDataGridView.CellValueChanged += questionDataGridView_CellValueChanged;
            questionDataGridView.SelectionChanged += questionDataGridView_SelectionChanged;
            questionDataGridView.UserDeletingRow += questionDataGridView_UserDeletingRow;
            questionDataGridView.MouseDown += questionDataGridView_MouseDown;
            // 
            // NewQuizButton
            // 
            NewQuizButton.Location = new Point(55, 93);
            NewQuizButton.Name = "NewQuizButton";
            NewQuizButton.Size = new Size(94, 29);
            NewQuizButton.TabIndex = 10;
            NewQuizButton.Text = "New Quiz";
            NewQuizButton.UseVisualStyleBackColor = true;
            NewQuizButton.Click += NewQuizButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(155, 93);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // quiztitleTextBox
            // 
            quiztitleTextBox.Location = new Point(255, 94);
            quiztitleTextBox.Name = "quiztitleTextBox";
            quiztitleTextBox.Size = new Size(220, 27);
            quiztitleTextBox.TabIndex = 12;
            // 
            // passcodeTextBox
            // 
            passcodeTextBox.Location = new Point(481, 93);
            passcodeTextBox.Name = "passcodeTextBox";
            passcodeTextBox.Size = new Size(152, 27);
            passcodeTextBox.TabIndex = 13;
            // 
            // validateLabel
            // 
            validateLabel.AutoSize = true;
            validateLabel.Location = new Point(639, 96);
            validateLabel.Name = "validateLabel";
            validateLabel.Size = new Size(63, 20);
            validateLabel.TabIndex = 14;
            validateLabel.Text = "Validate";
            // 
            // answersDataGridView
            // 
            answersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            answersDataGridView.Location = new Point(11, 305);
            answersDataGridView.MultiSelect = false;
            answersDataGridView.Name = "answersDataGridView";
            answersDataGridView.RowHeadersWidth = 51;
            answersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            answersDataGridView.Size = new Size(745, 163);
            answersDataGridView.TabIndex = 15;
            answersDataGridView.CellValueChanged += answersDataGridView_CellValueChanged;
            // 
            // questionContextMenuStrip
            // 
            questionContextMenuStrip.ImageScalingSize = new Size(20, 20);
            questionContextMenuStrip.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, addExistingQuestionToolStripMenuItem });
            questionContextMenuStrip.Name = "contextMenuStrip1";
            questionContextMenuStrip.Size = new Size(225, 52);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(224, 24);
            deleteToolStripMenuItem.Text = "Delete Question";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // addExistingQuestionToolStripMenuItem
            // 
            addExistingQuestionToolStripMenuItem.Name = "addExistingQuestionToolStripMenuItem";
            addExistingQuestionToolStripMenuItem.Size = new Size(224, 24);
            addExistingQuestionToolStripMenuItem.Text = "Add Existing Question";
            addExistingQuestionToolStripMenuItem.Click += addExistingQuestionToolStripMenuItem_Click;
            // 
            // QuizzesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(768, 480);
            Controls.Add(answersDataGridView);
            Controls.Add(validateLabel);
            Controls.Add(passcodeTextBox);
            Controls.Add(quiztitleTextBox);
            Controls.Add(saveButton);
            Controls.Add(NewQuizButton);
            Controls.Add(questionDataGridView);
            Controls.Add(BackButtonBox);
            Controls.Add(BannerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "QuizzesPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuizzesPage";
            BannerPanel.ResumeLayout(false);
            BannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackButtonBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)questionDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)answersDataGridView).EndInit();
            questionContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BannerPanel;
        private PictureBox UTDLogoBox;
        private Label CourseLabel;
        private Label LogoutLabel;
        private PictureBox BackButtonBox;
        private DataGridView questionDataGridView;
        private Button NewQuizButton;
        private Button saveButton;
        private TextBox quiztitleTextBox;
        private TextBox passcodeTextBox;
        private Label validateLabel;
        private DataGridView answersDataGridView;
        private ContextMenuStrip questionContextMenuStrip;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem addExistingQuestionToolStripMenuItem;
    }
}