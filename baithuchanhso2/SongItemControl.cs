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
        public SongItemControl()
        {
            InitializeComponent();
            this.Click += new EventHandler(SongItemControl_Click);
        }
        private string songTitle;
        private string songAuthor;
        private string songArtist;
        private string coverPath;
        private string songPath;

        private void SongItemControl_Click(object sender, EventArgs e)
        {
            OnSongItemClick(EventArgs.Empty);
        }
        public event EventHandler SongItemClick;

        protected virtual void OnSongItemClick(EventArgs e)
        {
            SongItemClick?.Invoke(this, e);
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
