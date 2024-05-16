using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baithuchanhso2
{
    public partial class SongItemControl : UserControl
    {
        private bool isFavorite;
        private bool hideFavorite=true;
        public SongItemControl()
        {
            InitializeComponent();
            this.Click += new EventHandler(SongItemControl_Click);
            picFavourite.Image = ButtonImage.heart_empty;
        }
        private string songTitle;
        private string songAuthor;
        private string songArtist;
        private string coverPath;
        private string songPath;
        private string timeListen;

        private void BtnFavorite_Click(object sender, EventArgs e)
        {
            ToggleFavorite();
        }

        public bool HideFavorite
        {
            get { return hideFavorite; }
            set
            {
                hideFavorite = value;
                picFavourite.Visible = hideFavorite;
            }
        }

        public bool IsFavorite
        {
            get { return isFavorite; }
            set
            {
                isFavorite = value;
                picFavourite.Image = isFavorite ?ButtonImage.heart_full  : ButtonImage.heart_empty;
            }
        }

        private void ToggleFavorite()
        {
            IsFavorite = !IsFavorite;
            UpdateFavoriteStatus();
        }

        private void UpdateFavoriteStatus()
        {
            // Code to update the song's favorite status in the main song list and save changes to file
            var mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.UpdateSongFavoriteStatus(this.SongTitle, IsFavorite);
            }
        }


        private void SongItemControl_Click(object sender, EventArgs e)
        {
            OnSongItemClick(EventArgs.Empty);
        }
        public event EventHandler SongItemClick;

        protected virtual void OnSongItemClick(EventArgs e)
        {
            SongItemClick?.Invoke(this, e);
        }

        public string TimeListen
        {
            get { return timeListen; }
            set
            {
                timeListen = value;
                lblLastListen.Text = value;
            }
        }

        public string SongPath
        {
            get { return songPath; }
            set { songPath = value; }
        }
        public string SongTitle
        {
            get { return songTitle; }
            set { songTitle = value; labelTitle.Text = value; }
        }

        //   public string SongAuthor
        //   {
        //      get { return songAuthor; }
        //        set { songAuthor = value; labelAuthor.Text = value; }
        //  }

        public string SongArtist
        {
            get { return songArtist; }
            set { songArtist = value; labelArtist.Text = value; }
        }

        public string SongAuthor
        {
            get { return songAuthor; }
            set
            {
                songAuthor = value; labelAuthor.Text = value;
            }
        }

        public string CoverPath
        {
            get { return coverPath; }
            set
            {
                coverPath = value;
                if (File.Exists(value))
                {
                    pictureBoxCover.Image = Image.FromFile(value);
                }
            }
        }
    }
}
