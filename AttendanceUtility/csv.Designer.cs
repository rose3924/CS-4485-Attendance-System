namespace AttendanceUtility
{
    partial class csv
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
            UTDLogoBox = new PictureBox();
            csvUpload = new Button();
            AttendanceDataGrid = new DataGridView();
            confirmChanges = new Button();
            BannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AttendanceDataGrid).BeginInit();
            SuspendLayout();
            // 
            // BannerPanel
            // 
            BannerPanel.BackColor = Color.FromArgb(29, 75, 54);
            BannerPanel.Controls.Add(LogoutLabel);
            BannerPanel.Controls.Add(UTDLogoBox);
            BannerPanel.Dock = DockStyle.Top;
            BannerPanel.Location = new Point(0, 0);
            BannerPanel.Margin = new Padding(5);
            BannerPanel.Name = "BannerPanel";
            BannerPanel.Size = new Size(1600, 169);
            BannerPanel.TabIndex = 2;
            // 
            // LogoutLabel
            // 
            LogoutLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LogoutLabel.AutoSize = true;
            LogoutLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutLabel.ForeColor = Color.FromArgb(192, 92, 31);
            LogoutLabel.ImageAlign = ContentAlignment.BottomRight;
            LogoutLabel.Location = new Point(2904, 189);
            LogoutLabel.Margin = new Padding(5, 0, 5, 0);
            LogoutLabel.Name = "LogoutLabel";
            LogoutLabel.Size = new Size(116, 41);
            LogoutLabel.TabIndex = 5;
            LogoutLabel.Text = "Logout";
            LogoutLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            // csvUpload
            // 
            csvUpload.Font = new Font("Yu Gothic UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            csvUpload.Location = new Point(1338, 181);
            csvUpload.Margin = new Padding(5);
            csvUpload.Name = "csvUpload";
            csvUpload.Size = new Size(248, 86);
            csvUpload.TabIndex = 9;
            csvUpload.Text = "Choose File";
            csvUpload.UseVisualStyleBackColor = true;
            csvUpload.Click += csvUpload_Click;
            // 
            // AttendanceDataGrid
            // 
            AttendanceDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendanceDataGrid.Location = new Point(23, 285);
            AttendanceDataGrid.Margin = new Padding(5);
            AttendanceDataGrid.Name = "AttendanceDataGrid";
            AttendanceDataGrid.RowHeadersWidth = 62;
            AttendanceDataGrid.Size = new Size(1552, 600);
            AttendanceDataGrid.TabIndex = 10;
            // 
            // confirmChanges
            // 
            confirmChanges.Font = new Font("Yu Gothic UI", 11.1F, FontStyle.Bold);
            confirmChanges.Location = new Point(1077, 181);
            confirmChanges.Margin = new Padding(5);
            confirmChanges.Name = "confirmChanges";
            confirmChanges.Size = new Size(248, 86);
            confirmChanges.TabIndex = 11;
            confirmChanges.Text = "Confirm";
            confirmChanges.UseVisualStyleBackColor = true;
            confirmChanges.Visible = false;
            confirmChanges.Click += confirmChanges_Click;
            // 
            // csv
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 896);
            Controls.Add(confirmChanges);
            Controls.Add(csvUpload);
            Controls.Add(AttendanceDataGrid);
            Controls.Add(BannerPanel);
            Name = "csv";
            Text = "csv";
            BannerPanel.ResumeLayout(false);
            BannerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UTDLogoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AttendanceDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BannerPanel;
        private Label LogoutLabel;
        private PictureBox UTDLogoBox;
        private Button csvUpload;
        private DataGridView AttendanceDataGrid;
        private Button confirmChanges;
    }
}