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
        private bool hideFavorite = true;
        private bool hideFolder = true;
        private bool hideDelete = false;

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
        private List<string> folderList;

        public bool HideDelete
        {
            get { return hideDelete; }
            set
            {
                hideDelete = value;
                btnDelete.Visible = hideDelete;
            }
        }
        public bool HideFolder
        {
            get { return hideFolder; }
            set
            {
                hideFolder = value;
                btnFolder.Visible = hideFolder;
            }
        }
        private void BtnFavorite_Click(object sender, EventArgs e)
        {
            ToggleFavorite();
        }

        public List<string> FolderList
        {
            get { return folderList; }
            set
            {
                folderList = value;
                playlistCombobox.DataSource = folderList;
            }
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
                picFavourite.Image = isFavorite ? ButtonImage.heart_full : ButtonImage.heart_empty;
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

        private void btnFolder_Click(object sender, EventArgs e)
        {
            btnFolder.Visible = false;
            playlistCombobox.Visible = true;
            addSong.Visible = true;
            rotate.Visible = true;
        }

        private void rotate_Click(object sender, EventArgs e)
        {
            btnFolder.Visible = true;
            playlistCombobox.Visible = false;
            addSong.Visible = false;
            rotate.Visible = false;
        }

        private bool IsSongExistsInPlaylist(string songTitle, string songsFilePath)
        {
            // Kiểm tra xem tên bài hát đã tồn tại trong tệp songs.txt của playlist hay không
            try
            {
                if (File.Exists(songsFilePath))
                {
                    string[] lines = File.ReadAllLines(songsFilePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length >= 1 && parts[0].Equals(songTitle))
                        {
                            return true; // Tên bài hát đã tồn tại trong playlist
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kiểm tra tên bài hát trong playlist: {ex.Message}");
            }

            return false; // Tên bài hát chưa tồn tại trong playlist
        }

        private void addSong_Click(object sender, EventArgs e)

        {
            string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string playlistFolder = Path.Combine(dataFolderPath, "Playlist");

            string selectedPlaylistName = playlistCombobox.SelectedItem.ToString();
            string playlistFolderPath = Path.Combine(playlistFolder, selectedPlaylistName);
            string songsFilePath = Path.Combine(playlistFolderPath, "songs.txt");

            if (IsSongExistsInPlaylist(SongTitle, songsFilePath))
            {
                MessageBox.Show("Bài hát đã tồn tại trong thư mục");
            }
            else
            {
                try
                {
                    // Ghi thông tin bài hát vào tệp songs.txt
                    using (StreamWriter writer = File.AppendText(songsFilePath))
                    {
                        string songFileName = Path.GetFileName(SongPath);
                        string coverFileName = Path.GetFileName(CoverPath);
                        writer.WriteLine($"{SongTitle}|{SongAuthor}|{SongArtist}|{songFileName}|{coverFileName}|{isFavorite}");
                    }
                    MessageBox.Show("Thêm vào playlist thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm vào playlist: {ex.Message}");
                }
            }



            btnFolder.Visible = true;
            playlistCombobox.Visible = false;
            addSong.Visible = false;
            rotate.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RemoveSongFromPlaylist(SongTitle);
        }

        public bool RemoveSongFromPlaylist( string songTitle)
        {
            string playlistName="";
            var mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.UpdateSongFavoriteStatus(this.SongTitle, IsFavorite);
                playlistName = mainForm.getPlaylistName();
            }
            try
            {
                string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
                string playlistFolder = Path.Combine(dataFolderPath, "Playlist");

                string playlistFolderPath = Path.Combine(playlistFolder, playlistName);
                string songsFilePath = Path.Combine(playlistFolderPath, "songs.txt");

                if (File.Exists(songsFilePath))
                {
                    // Đọc tất cả các dòng từ tệp songs.txt
                    List<string> lines = new List<string>(File.ReadAllLines(songsFilePath));

                    // Tìm và xóa dòng chứa thông tin của bài hát cần xóa
                    bool songRemoved = false;
                    for (int i = 0; i < lines.Count; i++)
                    {
                        string[] parts = lines[i].Split('|');
                        if (parts.Length > 0 && parts[0] == songTitle)
                        {
                            lines.RemoveAt(i);
                            songRemoved = true;
                            break;
                        }
                    }

                    // Nếu bài hát đã được xóa, ghi lại tất cả các dòng còn lại vào tệp songs.txt
                    if (songRemoved)
                    {
                        File.WriteAllLines(songsFilePath, lines);
                        mainForm.reloadPlaylis();
                        return true;
                    }
                    else
                    {
                        // Nếu bài hát không tồn tại trong playlist, trả về false
                        return false;
                    }
                }
                else
                {
                    // Nếu tệp songs.txt không tồn tại, trả về false
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra khi xóa bài hát khỏi playlist
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
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
