﻿namespace baithuchanhso2
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
            pictureBoxCover = new PictureBox();
            labelTitle = new Label();
            labelArtist = new Label();
            label1 = new Label();
            labelAuthor = new Label();
            lblTime = new Label();
            lblLastListen = new Label();
            picFavourite = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFavourite).BeginInit();
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
            labelTitle.ForeColor = Color.White;
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
            picFavourite.Image = Properties.Resources.close;
            picFavourite.Location = new Point(487, 22);
            picFavourite.Name = "picFavourite";
            picFavourite.Size = new Size(30, 30);
            picFavourite.SizeMode = PictureBoxSizeMode.StretchImage;
            picFavourite.TabIndex = 8;
            picFavourite.TabStop = false;
            picFavourite.Click += BtnFavorite_Click;
            // 
            // SongItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
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
    }
}
