namespace baithuchanhso2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pnlHistory = new Panel();
            lblHistory = new Label();
            picHistory = new PictureBox();
            pnlLibrary = new Panel();
            lblLibrary = new Label();
            picLibrary = new PictureBox();
            pnlSearch = new Panel();
            lblSearch = new Label();
            picSearch = new PictureBox();
            pnlHome = new Panel();
            lblHome = new Label();
            picHome = new PictureBox();
            panel1.SuspendLayout();
            pnlHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHistory).BeginInit();
            pnlLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLibrary).BeginInit();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).BeginInit();
            pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 9, 9);
            panel1.Controls.Add(pnlHistory);
            panel1.Controls.Add(pnlLibrary);
            panel1.Controls.Add(pnlSearch);
            panel1.Controls.Add(pnlHome);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 796);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 83);
            panel1.TabIndex = 0;
            // 
            // pnlHistory
            // 
            pnlHistory.Controls.Add(lblHistory);
            pnlHistory.Controls.Add(picHistory);
            pnlHistory.Dock = DockStyle.Left;
            pnlHistory.Location = new Point(420, 0);
            pnlHistory.Name = "pnlHistory";
            pnlHistory.Size = new Size(140, 83);
            pnlHistory.TabIndex = 4;
            pnlHistory.Click += pnlHistory_Click;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistory.ForeColor = SystemColors.ActiveBorder;
            lblHistory.Location = new Point(43, 57);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(55, 20);
            lblHistory.TabIndex = 1;
            lblHistory.Text = "Lịch sử";
            lblHistory.Click += pnlHistory_Click;
            // 
            // picHistory
            // 
            picHistory.Image = (Image)resources.GetObject("picHistory.Image");
            picHistory.Location = new Point(50, 10);
            picHistory.Name = "picHistory";
            picHistory.Size = new Size(40, 40);
            picHistory.SizeMode = PictureBoxSizeMode.StretchImage;
            picHistory.TabIndex = 0;
            picHistory.TabStop = false;
            picHistory.Click += pnlHistory_Click;
            // 
            // pnlLibrary
            // 
            pnlLibrary.Controls.Add(lblLibrary);
            pnlLibrary.Controls.Add(picLibrary);
            pnlLibrary.Dock = DockStyle.Left;
            pnlLibrary.Location = new Point(280, 0);
            pnlLibrary.Name = "pnlLibrary";
            pnlLibrary.Size = new Size(140, 83);
            pnlLibrary.TabIndex = 3;
            pnlLibrary.Click += pnlLibrary_Click;
            // 
            // lblLibrary
            // 
            lblLibrary.AutoSize = true;
            lblLibrary.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibrary.ForeColor = SystemColors.ActiveBorder;
            lblLibrary.Location = new Point(34, 57);
            lblLibrary.Name = "lblLibrary";
            lblLibrary.Size = new Size(68, 20);
            lblLibrary.TabIndex = 1;
            lblLibrary.Text = "Thư viện";
            lblLibrary.Click += pnlLibrary_Click;
            // 
            // picLibrary
            // 
            picLibrary.Image = (Image)resources.GetObject("picLibrary.Image");
            picLibrary.Location = new Point(50, 10);
            picLibrary.Name = "picLibrary";
            picLibrary.Size = new Size(40, 40);
            picLibrary.SizeMode = PictureBoxSizeMode.StretchImage;
            picLibrary.TabIndex = 0;
            picLibrary.TabStop = false;
            picLibrary.Click += pnlLibrary_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Controls.Add(picSearch);
            pnlSearch.Dock = DockStyle.Left;
            pnlSearch.Location = new Point(140, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(140, 83);
            pnlSearch.TabIndex = 2;
            pnlSearch.Click += pnlSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = SystemColors.ActiveBorder;
            lblSearch.Location = new Point(36, 57);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(71, 20);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Tìm kiếm";
            lblSearch.Click += pnlSearch_Click;
            // 
            // picSearch
            // 
            picSearch.Image = (Image)resources.GetObject("picSearch.Image");
            picSearch.Location = new Point(50, 10);
            picSearch.Name = "picSearch";
            picSearch.Size = new Size(40, 40);
            picSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            picSearch.TabIndex = 0;
            picSearch.TabStop = false;
            picSearch.Click += pnlSearch_Click;
            // 
            // pnlHome
            // 
            pnlHome.Controls.Add(lblHome);
            pnlHome.Controls.Add(picHome);
            pnlHome.Dock = DockStyle.Left;
            pnlHome.Location = new Point(0, 0);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(140, 83);
            pnlHome.TabIndex = 1;
            pnlHome.Click += pnlHome_Click;
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHome.ForeColor = SystemColors.ActiveBorder;
            lblHome.Location = new Point(33, 57);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(77, 20);
            lblHome.TabIndex = 1;
            lblHome.Text = "Trang chủ";
            lblHome.Click += pnlHome_Click;
            // 
            // picHome
            // 
            picHome.Image = (Image)resources.GetObject("picHome.Image");
            picHome.Location = new Point(50, 10);
            picHome.Name = "picHome";
            picHome.Size = new Size(40, 40);
            picHome.SizeMode = PictureBoxSizeMode.StretchImage;
            picHome.TabIndex = 0;
            picHome.TabStop = false;
            picHome.Click += pnlHome_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(560, 879);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            pnlHistory.ResumeLayout(false);
            pnlHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHistory).EndInit();
            pnlLibrary.ResumeLayout(false);
            pnlLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLibrary).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).EndInit();
            pnlHome.ResumeLayout(false);
            pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlHome;
        private PictureBox picHome;
        private Label lblHome;
        private Panel pnlHistory;
        private Label lblHistory;
        private PictureBox picHistory;
        private Panel pnlLibrary;
        private Label lblLibrary;
        private PictureBox picLibrary;
        private Panel pnlSearch;
        private Label lblSearch;
        private PictureBox picSearch;
    }
}
