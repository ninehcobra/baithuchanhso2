namespace baithuchanhso2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel2 = new Panel();
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panelMenu = new Panel();
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
            searchPanel = new Panel();
            flowLayoutPanelSongs = new FlowLayoutPanel();
            songItemControl1 = new SongItemControl();
            panel1 = new Panel();
            comboBoxGenres = new ComboBox();
            pictureBox3 = new PictureBox();
            txtSearch = new TextBox();
            historyPanel = new Panel();
            flowLayoutPanelHistory = new FlowLayoutPanel();
            songItemControl2 = new SongItemControl();
            panel3 = new Panel();
            label1 = new Label();
            panelCurrentPlaySong = new Panel();
            lblSongCurrentTitle = new Label();
            lblCurrentPlaySong = new Label();
            picCurrentPlaySong = new PictureBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelMenu.SuspendLayout();
            pnlHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHistory).BeginInit();
            pnlLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLibrary).BeginInit();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).BeginInit();
            pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            searchPanel.SuspendLayout();
            flowLayoutPanelSongs.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            historyPanel.SuspendLayout();
            flowLayoutPanelHistory.SuspendLayout();
            panel3.SuspendLayout();
            panelCurrentPlaySong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCurrentPlaySong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(560, 55);
            panel2.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(61, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(95, 25);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Trang chủ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close;
            pictureBox1.Location = new Point(510, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(9, 9, 9);
            panelMenu.Controls.Add(pnlHistory);
            panelMenu.Controls.Add(pnlLibrary);
            panelMenu.Controls.Add(pnlSearch);
            panelMenu.Controls.Add(pnlHome);
            panelMenu.Dock = DockStyle.Bottom;
            panelMenu.Location = new Point(0, 796);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(560, 83);
            panelMenu.TabIndex = 5;
            // 
            // pnlHistory
            // 
            pnlHistory.Controls.Add(lblHistory);
            pnlHistory.Controls.Add(picHistory);
            pnlHistory.Dock = DockStyle.Right;
            pnlHistory.Location = new Point(140, 0);
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
            pnlLibrary.Dock = DockStyle.Right;
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
            pnlSearch.Dock = DockStyle.Right;
            pnlSearch.Location = new Point(420, 0);
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
            // searchPanel
            // 
            searchPanel.Controls.Add(flowLayoutPanelSongs);
            searchPanel.Controls.Add(panel1);
            searchPanel.Location = new Point(358, 135);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(560, 741);
            searchPanel.TabIndex = 6;
            searchPanel.Visible = false;
            // 
            // flowLayoutPanelSongs
            // 
            flowLayoutPanelSongs.AutoScroll = true;
            flowLayoutPanelSongs.Controls.Add(songItemControl1);
            flowLayoutPanelSongs.Dock = DockStyle.Top;
            flowLayoutPanelSongs.Location = new Point(0, 61);
            flowLayoutPanelSongs.Name = "flowLayoutPanelSongs";
            flowLayoutPanelSongs.Size = new Size(560, 700);
            flowLayoutPanelSongs.TabIndex = 6;
            // 
            // songItemControl1
            // 
            songItemControl1.BackColor = Color.FromArgb(9, 9, 9);
            songItemControl1.CoverPath = null;
            songItemControl1.Location = new Point(3, 3);
            songItemControl1.Name = "songItemControl1";
            songItemControl1.Size = new Size(557, 72);
            songItemControl1.SongArtist = null;
            songItemControl1.SongAuthor = null;
            songItemControl1.SongPath = null;
            songItemControl1.SongTitle = null;
            songItemControl1.TabIndex = 3;
            songItemControl1.TimeListen = null;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxGenres);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 61);
            panel1.TabIndex = 5;
            // 
            // comboBoxGenres
            // 
            comboBoxGenres.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenres.FormattingEnabled = true;
            comboBoxGenres.ItemHeight = 15;
            comboBoxGenres.Location = new Point(437, 16);
            comboBoxGenres.Name = "comboBoxGenres";
            comboBoxGenres.Size = new Size(111, 23);
            comboBoxGenres.TabIndex = 1;
            comboBoxGenres.SelectedIndexChanged += comboBoxGenres_SelectedIndexChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.magnifying_glass;
            pictureBox3.Location = new Point(17, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(58, 13);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(362, 29);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += SearchSongs;
            txtSearch.Enter += RemovePlaceholder;
            txtSearch.Leave += SetPlaceholder;
            // 
            // historyPanel
            // 
            historyPanel.Controls.Add(flowLayoutPanelHistory);
            historyPanel.Controls.Add(panel3);
            historyPanel.Location = new Point(61, 88);
            historyPanel.Name = "historyPanel";
            historyPanel.Size = new Size(560, 700);
            historyPanel.TabIndex = 8;
            historyPanel.Visible = false;
            // 
            // flowLayoutPanelHistory
            // 
            flowLayoutPanelHistory.AutoScroll = true;
            flowLayoutPanelHistory.Controls.Add(songItemControl2);
            flowLayoutPanelHistory.Dock = DockStyle.Top;
            flowLayoutPanelHistory.Location = new Point(0, 71);
            flowLayoutPanelHistory.Name = "flowLayoutPanelHistory";
            flowLayoutPanelHistory.Size = new Size(560, 661);
            flowLayoutPanelHistory.TabIndex = 1;
            // 
            // songItemControl2
            // 
            songItemControl2.BackColor = Color.Transparent;
            songItemControl2.CoverPath = null;
            songItemControl2.Location = new Point(3, 3);
            songItemControl2.Name = "songItemControl2";
            songItemControl2.Size = new Size(554, 84);
            songItemControl2.SongArtist = null;
            songItemControl2.SongAuthor = null;
            songItemControl2.SongPath = null;
            songItemControl2.SongTitle = null;
            songItemControl2.TabIndex = 0;
            songItemControl2.TimeListen = null;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(560, 71);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 6;
            label1.Text = "Đã phát gần đây";
            // 
            // panelCurrentPlaySong
            // 
            panelCurrentPlaySong.Controls.Add(lblSongCurrentTitle);
            panelCurrentPlaySong.Controls.Add(lblCurrentPlaySong);
            panelCurrentPlaySong.Controls.Add(picCurrentPlaySong);
            panelCurrentPlaySong.Controls.Add(axWindowsMediaPlayer1);
            panelCurrentPlaySong.Dock = DockStyle.Bottom;
            panelCurrentPlaySong.Location = new Point(0, 713);
            panelCurrentPlaySong.Name = "panelCurrentPlaySong";
            panelCurrentPlaySong.Size = new Size(560, 83);
            panelCurrentPlaySong.TabIndex = 9;
            panelCurrentPlaySong.Visible = false;
            // 
            // lblSongCurrentTitle
            // 
            lblSongCurrentTitle.AutoSize = true;
            lblSongCurrentTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSongCurrentTitle.ForeColor = SystemColors.ControlLightLight;
            lblSongCurrentTitle.Location = new Point(88, 8);
            lblSongCurrentTitle.Name = "lblSongCurrentTitle";
            lblSongCurrentTitle.Size = new Size(37, 15);
            lblSongCurrentTitle.TabIndex = 7;
            lblSongCurrentTitle.Text = "label1";
            // 
            // lblCurrentPlaySong
            // 
            lblCurrentPlaySong.AutoSize = true;
            lblCurrentPlaySong.ForeColor = Color.White;
            lblCurrentPlaySong.Location = new Point(72, 17);
            lblCurrentPlaySong.Name = "lblCurrentPlaySong";
            lblCurrentPlaySong.Size = new Size(0, 15);
            lblCurrentPlaySong.TabIndex = 6;
            // 
            // picCurrentPlaySong
            // 
            picCurrentPlaySong.Location = new Point(12, 10);
            picCurrentPlaySong.Name = "picCurrentPlaySong";
            picCurrentPlaySong.Size = new Size(65, 65);
            picCurrentPlaySong.SizeMode = PictureBoxSizeMode.StretchImage;
            picCurrentPlaySong.TabIndex = 5;
            picCurrentPlaySong.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(87, 28);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(464, 47);
            axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(560, 879);
            Controls.Add(panelCurrentPlaySong);
            Controls.Add(historyPanel);
            Controls.Add(searchPanel);
            Controls.Add(panelMenu);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelMenu.ResumeLayout(false);
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
            searchPanel.ResumeLayout(false);
            flowLayoutPanelSongs.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            historyPanel.ResumeLayout(false);
            flowLayoutPanelHistory.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelCurrentPlaySong.ResumeLayout(false);
            panelCurrentPlaySong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCurrentPlaySong).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
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
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private PictureBox pictureBox2;
        private Panel searchPanel;
        private FlowLayoutPanel flowLayoutPanelSongs;
        private SongItemControl songItemControl1;
        private Panel panel1;
        private ComboBox comboBoxGenres;
        private TextBox txtSearch;
        private PictureBox pictureBox3;
        private Panel historyPanel;
        private FlowLayoutPanel flowLayoutPanelHistory;
        private SongItemControl songItemControl2;
        private Panel panel3;
        private Label label1;
        private Panel panelCurrentPlaySong;
        private Label lblSongCurrentTitle;
        private Label lblCurrentPlaySong;
        private PictureBox picCurrentPlaySong;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
