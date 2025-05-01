namespace AttendanceUtility
{
    partial class QuestionsPage
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
            CourseLabel = new Label();
            UTDLogoBox = new PictureBox();
            QuestionsDataGrid = new DataGridView();
            selectQuestionButton = new Button();
            cancelButton = new Button();
            BannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuestionsDataGrid).BeginInit();
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
            BannerPanel.Size = new Size(672, 62);
            BannerPanel.TabIndex = 1;
            // 
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseLabel.ForeColor = Color.White;
            CourseLabel.Location = new Point(111, 16);
            CourseLabel.Margin = new Padding(2, 0, 2, 0);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(239, 30);
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
            UTDLogoBox.Size = new Size(107, 61);
            UTDLogoBox.SizeMode = PictureBoxSizeMode.Zoom;
            UTDLogoBox.TabIndex = 0;
            UTDLogoBox.TabStop = false;
            // 
            // QuestionsDataGrid
            // 
            QuestionsDataGrid.AllowUserToAddRows = false;
            QuestionsDataGrid.AllowUserToDeleteRows = false;
            QuestionsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QuestionsDataGrid.Location = new Point(4, 96);
            QuestionsDataGrid.Margin = new Padding(2);
            QuestionsDataGrid.Name = "QuestionsDataGrid";
            QuestionsDataGrid.ReadOnly = true;
            QuestionsDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            QuestionsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            QuestionsDataGrid.RowHeadersWidth = 62;
            QuestionsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            QuestionsDataGrid.Size = new Size(661, 255);
            QuestionsDataGrid.TabIndex = 9;
            // 
            // selectQuestionButton
            // 
            selectQuestionButton.Location = new Point(85, 67);
            selectQuestionButton.Name = "selectQuestionButton";
            selectQuestionButton.Size = new Size(105, 23);
            selectQuestionButton.TabIndex = 10;
            selectQuestionButton.Text = "Select Question";
            selectQuestionButton.UseVisualStyleBackColor = true;
            selectQuestionButton.Click += selectQuestionButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(4, 67);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // QuestionsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(672, 360);
            Controls.Add(cancelButton);
            Controls.Add(selectQuestionButton);
            Controls.Add(QuestionsDataGrid);
            Controls.Add(BannerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "QuestionsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuizzesPage";
            Load += QuestionsPage_Load;
            BannerPanel.ResumeLayout(false);
            BannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuestionsDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BannerPanel;
        private PictureBox UTDLogoBox;
        private Label CourseLabel;
        private DataGridView QuestionsDataGrid;
        private Button selectQuestionButton;
        private Button cancelButton;
    }
}