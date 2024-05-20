namespace baithuchanhso2
{
    partial class SongItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongItemControl));
            pictureBoxCover = new PictureBox();
            labelTitle = new Label();
            labelArtist = new Label();
            label1 = new Label();
            labelAuthor = new Label();
            lblTime = new Label();
            lblLastListen = new Label();
            picFavourite = new PictureBox();
            playlistCombobox = new ComboBox();
            addSong = new PictureBox();
            rotate = new PictureBox();
            btnFolder = new PictureBox();
            btnDelete = new PictureBox();
            btn_Download = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFavourite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addSong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rotate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnFolder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Download).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCover
            // 
            pictureBoxCover.Image = Properties.Resources.home_active;
            pictureBoxCover.Location = new Point(13, 10);
            pictureBoxCover.Name = "pictureBoxCover";
            pictureBoxCover.Size = new Size(60, 60);
            pictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCover.TabIndex = 0;
            pictureBoxCover.TabStop = false;
            pictureBoxCover.Click += SongItemControl_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(95, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(124, 20);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Vai Lan Don Dua";
            labelTitle.Click += SongItemControl_Click;
            // 
            // labelArtist
            // 
            labelArtist.AutoSize = true;
            labelArtist.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelArtist.ForeColor = Color.DimGray;
            labelArtist.Location = new Point(97, 37);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(52, 15);
            labelArtist.TabIndex = 2;
            labelArtist.Text = "SOOBIN";
            labelArtist.Click += SongItemControl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(97, 54);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Tác giả: ";
            label1.Click += SongItemControl_Click;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAuthor.ForeColor = Color.DimGray;
            labelAuthor.Location = new Point(141, 54);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(52, 15);
            labelAuthor.TabIndex = 5;
            labelAuthor.Text = "SOOBIN";
            labelAuthor.Click += SongItemControl_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.ForeColor = SystemColors.Window;
            lblTime.Location = new Point(392, 31);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 15);
            lblTime.TabIndex = 6;
            // 
            // lblLastListen
            // 
            lblLastListen.AutoSize = true;
            lblLastListen.ForeColor = SystemColors.ControlLightLight;
            lblLastListen.Location = new Point(364, 59);
            lblLastListen.Name = "lblLastListen";
            lblLastListen.Size = new Size(0, 15);
            lblLastListen.TabIndex = 7;
            // 
            // picFavourite
            // 
            picFavourite.Image = Properties.Resources.plus;
            picFavourite.Location = new Point(464, 22);
            picFavourite.Name = "picFavourite";
            picFavourite.Size = new Size(30, 30);
            picFavourite.SizeMode = PictureBoxSizeMode.StretchImage;
            picFavourite.TabIndex = 8;
            picFavourite.TabStop = false;
            picFavourite.Click += BtnFavorite_Click;
            // 
            // playlistCombobox
            // 
            playlistCombobox.FormattingEnabled = true;
            playlistCombobox.Location = new Point(360, 13);
            playlistCombobox.Name = "playlistCombobox";
            playlistCombobox.Size = new Size(94, 23);
            playlistCombobox.TabIndex = 9;
            playlistCombobox.Visible = false;
            // 
            // addSong
            // 
            addSong.Image = Properties.Resources.check;
            addSong.Location = new Point(412, 42);
            addSong.Name = "addSong";
            addSong.Size = new Size(25, 25);
            addSong.SizeMode = PictureBoxSizeMode.StretchImage;
            addSong.TabIndex = 10;
            addSong.TabStop = false;
            addSong.Visible = false;
            addSong.Click += addSong_Click;
            // 
            // rotate
            // 
            rotate.Image = Properties.Resources.rotate;
            rotate.Location = new Point(377, 42);
            rotate.Name = "rotate";
            rotate.Size = new Size(25, 25);
            rotate.SizeMode = PictureBoxSizeMode.StretchImage;
            rotate.TabIndex = 11;
            rotate.TabStop = false;
            rotate.Visible = false;
            rotate.Click += rotate_Click;
            // 
            // btnFolder
            // 
            btnFolder.Image = Properties.Resources.folder;
            btnFolder.Location = new Point(426, 21);
            btnFolder.Name = "btnFolder";
            btnFolder.Size = new Size(30, 30);
            btnFolder.SizeMode = PictureBoxSizeMode.StretchImage;
            btnFolder.TabIndex = 12;
            btnFolder.TabStop = false;
            btnFolder.Click += btnFolder_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(424, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(30, 30);
            btnDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            btnDelete.TabIndex = 13;
            btnDelete.TabStop = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btn_Download
            // 
            btn_Download.Image = (Image)resources.GetObject("btn_Download.Image");
            btn_Download.Location = new Point(502, 22);
            btn_Download.Name = "btn_Download";
            btn_Download.Size = new Size(30, 30);
            btn_Download.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Download.TabIndex = 14;
            btn_Download.TabStop = false;
            btn_Download.Click += btn_Download_Click;
            // 
            // SongItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btn_Download);
            Controls.Add(btnDelete);
            Controls.Add(btnFolder);
            Controls.Add(rotate);
            Controls.Add(addSong);
            Controls.Add(playlistCombobox);
            Controls.Add(picFavourite);
            Controls.Add(lblLastListen);
            Controls.Add(lblTime);
            Controls.Add(labelAuthor);
            Controls.Add(label1);
            Controls.Add(labelArtist);
            Controls.Add(labelTitle);
            Controls.Add(pictureBoxCover);
            Name = "SongItemControl";
            Size = new Size(545, 84);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFavourite).EndInit();
            ((System.ComponentModel.ISupportInitialize)addSong).EndInit();
            ((System.ComponentModel.ISupportInitialize)rotate).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnFolder).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Download).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCover;
        private Label labelTitle;
        private Label labelArtist;
        private Label label1;
        private Label labelAuthor;
        private Label lblTime;
        private Label lblLastListen;
        private PictureBox picFavourite;
        private ComboBox playlistCombobox;
        private PictureBox addSong;
        private PictureBox rotate;
        private PictureBox btnFolder;
        private PictureBox btnDelete;
        private PictureBox btn_Download;
    }
}
