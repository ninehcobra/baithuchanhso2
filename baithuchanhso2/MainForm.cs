using baithuchanhso2.Repository;
using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace baithuchanhso2
{
    public partial class MainForm : Form
    {

        string activePanel = "Home";

        private List<Song> allSongs;
        private List<Song> favouriteSongs;
        private List<History> histories;
        private SongRepository songRepository;
        private HistoryRepository historyRepository;

        string placeholderSearch = "Bạn muốn nghe gì?";

        private List<string> allFolders;
        private SongItemControl currentSong;


        public MainForm()
        {
            InitializeComponent();
            flowLayoutPanelSongs.WrapContents = false;
            flowLayoutPanelSongs.FlowDirection = FlowDirection.TopDown;
            string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            songRepository = new SongRepository(dataFolderPath);
            historyRepository = new HistoryRepository(dataFolderPath);
            LoadSongs();

            SetActiveButton();
            InitializeSearchTextBox();

            var genres = new List<string> { "Tất cả", "Pop", "Ballad", "Rap", "Indie" };
            comboBoxGenres.Items.AddRange(genres.ToArray());
            comboBoxGenres.SelectedIndex = 0;


            searchPanel.Dock = DockStyle.Top;
            historyPanel.Dock = DockStyle.Top;
            favouritePanel.Dock = DockStyle.Top;
            folderPanel.Dock = DockStyle.Top;
            playlistPanel.Dock = DockStyle.Top;
            downloadPanel.Dock = DockStyle.Top;
            detailPanel.Dock = DockStyle.Top;

            DisplayFolder();


        }

        public void DisplayFolder()
        {
            allFolders = GetPlaylistNames();
            flowLayoutPanelFolder.Controls.Clear();
            foreach (var folder in allFolders)
            {
                var playlist = new Playlist
                {
                    PlaylistName = folder,
                };




                flowLayoutPanelFolder.Controls.Add(playlist);
            }
        }

        private void PlaySong(string songPath)
        {
            // Play the selected song
            axWindowsMediaPlayer1.URL = songPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void SaveSongToHistory(SongItemControl songItem)
        {
            string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string historyFilePath = Path.Combine(dataFolderPath, "song_history.txt");
            string songFileName = Path.GetFileName(songItem.SongPath);
            string coverFileName = Path.GetFileName(songItem.CoverPath);

            string songInfo = $"{songItem.SongTitle}|{songItem.SongAuthor}|{songItem.SongArtist}|{songFileName}|{coverFileName}|{DateTime.Now}";

            List<string> historyLines = new List<string>();

            try
            {
                // Đọc các dòng từ tệp lịch sử
                if (File.Exists(historyFilePath))
                {
                    historyLines = File.ReadAllLines(historyFilePath).ToList();
                }

                // Xóa bản ghi trùng lặp
                historyLines.RemoveAll(line => line.Split('|')[0] == songItem.SongTitle);

                // Thêm bản ghi mới vào danh sách
                historyLines.Add(songInfo);

                // Ghi lại danh sách lịch sử vào tệp
                File.WriteAllLines(historyFilePath, historyLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving song history: {ex.Message}");
            }
        }

        private void FilterSongsByGenre(string genre)
        {
            var filteredSongs = genre == "Tất cả" ? allSongs : allSongs.Where(song => song.Genre == genre).ToList();
            DisplaySongs(filteredSongs);
            SearchSongs(txtSearch.Text == placeholderSearch ? "" : txtSearch.Text);
        }



        private void InitializeSearchTextBox()
        {
            txtSearch.Text = placeholderSearch;
            txtSearch.ForeColor = Color.Gray;


        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.ForeColor == Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholderSearch;
                textBox.ForeColor = Color.Gray;
            }
        }


        private void LoadSongs()
        {
            allSongs = songRepository.LoadSongs();
            DisplaySongs(allSongs);
            histories = historyRepository.LoadSongs();
            DisplayHistory(histories.AsEnumerable().Reverse().ToList());
            favouriteSongs = allSongs.Where(song => song.IsFavorite == true).ToList();
            DisplayFavourite(favouriteSongs);
        }

        private void DisplayHistory(List<History> songs)
        {
            flowLayoutPanelHistory.Controls.Clear();
            foreach (var song in songs)
            {
                var songItemControl = new SongItemControl
                {
                    SongTitle = song.Title,
                    SongAuthor = song.Author,
                    SongArtist = song.Artist,
                    CoverPath = song.CoverPath,
                    SongPath = song.FilePath,
                    TimeListen = song.Time,
                    HideFavorite = false,
                    HideDelete = false,
                    HideFolder = false,
                    Width = flowLayoutPanelHistory.Width - 20 // Adjust the width as needed
                };
                songItemControl.SongItemClick += SongItemControl_SongItemClick;
                flowLayoutPanelHistory.Controls.Add(songItemControl);
            }
        }

        private void DisplayFavourite(List<Song> songs)
        {
            flowLayoutPanelFavourite.Controls.Clear();
            foreach (var song in songs)
            {
                var songItemControl = new SongItemControl
                {
                    SongTitle = song.Title,
                    SongAuthor = song.Author,
                    SongArtist = song.Artist,
                    CoverPath = song.CoverPath,
                    SongPath = song.FilePath,
                    IsFavorite = song.IsFavorite,
                    HideDelete = false,
                    HideFolder = false,

                    Width = flowLayoutPanelFavourite.Width - 20 // Adjust the width as needed
                };
                songItemControl.SongItemClick += SongItemControl_SongItemClick;
                flowLayoutPanelFavourite.Controls.Add(songItemControl);
            }
        }

        private void DisplaySongs(List<Song> songs)
        {
            flowLayoutPanelSongs.Controls.Clear();
            foreach (var song in songs)
            {
                allFolders = GetPlaylistNames();
                var songItemControl = new SongItemControl
                {
                    SongTitle = song.Title,
                    SongAuthor = song.Author,
                    SongArtist = song.Artist,
                    CoverPath = song.CoverPath,
                    SongPath = song.FilePath,
                    IsFavorite = song.IsFavorite,
                    FolderList = allFolders,
                    HideDelete = false,

                    Width = flowLayoutPanelSongs.Width - 20 // Adjust the width as needed
                };
                songItemControl.SongItemClick += SongItemControl_SongItemClick;
                flowLayoutPanelSongs.Controls.Add(songItemControl);
            }
        }

        private void SongItemControl_SongItemClick(object sender, EventArgs e)
        {
            var songItem = sender as SongItemControl;
            if (songItem != null)
            {
                PlaySong(songItem.SongPath);
                currentSong = songItem;
                panelCurrentPlaySong.Visible = true;
                lblSongCurrentTitle.Text = songItem.SongTitle + " - " + songItem.SongArtist;
                picCurrentPlaySong.Image = Image.FromFile(songItem.CoverPath);

                SaveSongToHistory(songItem);
            }
        }

        public void UpdateSongFavoriteStatus(string songTitle, bool isFavorite)
        {
            var song = allSongs.FirstOrDefault(s => s.Title == songTitle);
            if (song != null)
            {
                song.IsFavorite = isFavorite;
                songRepository.SaveSongs(allSongs);
            }
            favouriteSongs = allSongs.Where(song => song.IsFavorite == true).ToList();
            DisplayFavourite(favouriteSongs);
        }


        public void SetActiveButton()
        {
            allFolders = GetPlaylistNames();
            if (activePanel == "Home")
            {
                lblTitle.Text = "Thư mục";
                lblHome.ForeColor = ColorTranslator.FromHtml("#f5f5f5");
                picHome.Image = ButtonImage.folder_active;


                lblLibrary.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picLibrary.Image = ButtonImage.favourite_normal;
                lblSearch.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picSearch.Image = ButtonImage.search_normal;
                lblHistory.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHistory.Image = ButtonImage.history_normal;

                playlistPanel.Visible = false;
                searchPanel.Visible = false;
                historyPanel.Visible = false;
                favouritePanel.Visible = false;
                downloadPanel.Visible = false;
                folderPanel.Visible = true;
                detailPanel.Visible = false;
                DisplayFolder();
            }
            else if (activePanel == "Search")
            {
                lblTitle.Text = "Tìm kiếm";
                lblSearch.ForeColor = ColorTranslator.FromHtml("#f5f5f5");
                picSearch.Image = ButtonImage.search_active;

                lblHome.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHome.Image = ButtonImage.folder_normal;
                lblLibrary.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picLibrary.Image = ButtonImage.favourite_normal;
                lblHistory.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHistory.Image = ButtonImage.history_normal;

                playlistPanel.Visible = false;
                searchPanel.Visible = true;
                historyPanel.Visible = false;
                favouritePanel.Visible = false;
                folderPanel.Visible = false;
                downloadPanel.Visible = false;
                detailPanel.Visible = false;
            }
            else if (activePanel == "Library")
            {
                lblTitle.Text = "Danh sách yêu thích";
                lblLibrary.ForeColor = ColorTranslator.FromHtml("#f5f5f5");
                picLibrary.Image = ButtonImage.favourite_active;

                lblHome.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHome.Image = ButtonImage.folder_normal;
                lblSearch.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picSearch.Image = ButtonImage.search_normal;
                lblHistory.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHistory.Image = ButtonImage.history_normal;

                playlistPanel.Visible = false;
                searchPanel.Visible = false;
                historyPanel.Visible = false;
                favouritePanel.Visible = true;
                folderPanel.Visible = false;
                downloadPanel.Visible = false;
                detailPanel.Visible = false;
            }
            else if (activePanel == "History")
            {
                lblTitle.Text = "Lịch sử";

                lblHistory.ForeColor = ColorTranslator.FromHtml("#f5f5f5");
                picHistory.Image = ButtonImage.history_active;

                lblHome.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHome.Image = ButtonImage.folder_normal;
                lblLibrary.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picLibrary.Image = ButtonImage.favourite_normal;
                lblSearch.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picSearch.Image = ButtonImage.search_normal;

                playlistPanel.Visible = false;
                searchPanel.Visible = false;
                historyPanel.Visible = true;
                favouritePanel.Visible = false;
                folderPanel.Visible = false;
                downloadPanel.Visible = false;
                detailPanel.Visible = false;

                histories = historyRepository.LoadSongs();
                DisplayHistory(histories.AsEnumerable().Reverse().ToList());


            }
            else if (activePanel == "")
            {
                lblHome.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHome.Image = ButtonImage.home_normal;
                lblLibrary.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picLibrary.Image = ButtonImage.favourite_normal;
                lblSearch.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picSearch.Image = ButtonImage.search_normal;
                lblHistory.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHistory.Image = ButtonImage.history_normal;

                playlistPanel.Visible = false;
                searchPanel.Visible = false;
                historyPanel.Visible = false;
                favouritePanel.Visible = false;
                folderPanel.Visible = false;
                downloadPanel.Visible = false;
                detailPanel.Visible = false;
            }
            LoadSongs();
        }

        private void pnlHome_Click(object sender, EventArgs e)
        {
            if (activePanel != "Home")
            {
                activePanel = "Home";
            }
            else
            {
                activePanel = "Home";
            }

            SetActiveButton();
        }

        private void pnlSearch_Click(object sender, EventArgs e)
        {
            if (activePanel != "Search")
            {
                activePanel = "Search";
            }
            else
            {
                activePanel = "Home";
            }

            SetActiveButton();
        }

        private void pnlLibrary_Click(object sender, EventArgs e)
        {
            if (activePanel != "Library")
            {
                activePanel = "Library";
            }
            else
            {
                activePanel = "Home";
            }

            SetActiveButton();
        }

        private void pnlHistory_Click(object sender, EventArgs e)
        {
            if (activePanel != "History")
            {
                activePanel = "History";
            }
            else
            {
                activePanel = "Home";
            }

            SetActiveButton();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGenre = comboBoxGenres.SelectedItem.ToString();

            FilterSongsByGenre(selectedGenre);
        }

        private void SearchSongs(object sender, EventArgs e)
        {
            SearchSongs(txtSearch.Text);
        }

        private void SearchSongs(string keyword)
        {
            if (keyword != placeholderSearch)
            {
                try
                {
                    int genreId = comboBoxGenres.SelectedIndex;
                    string selectedGenre = comboBoxGenres.Items[genreId].ToString();
                    var filteredSongs = selectedGenre == "Tất cả" ? allSongs : allSongs.Where(song => song.Genre == selectedGenre).ToList();


                    var searchedSongs = filteredSongs.Where(song =>
                        song.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                        song.Artist.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                        song.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
                    DisplaySongs(searchedSongs);
                }
                catch
                {

                    var searchedSongs = allSongs.Where(song =>
                        song.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                        song.Artist.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                        song.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
                    DisplaySongs(searchedSongs);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string playlistFolder = Path.Combine(dataFolderPath, "Playlist");

            if (txtFolder.Text != "")
            {
                try
                {

                    string playlistFolderPath = Path.Combine(playlistFolder, txtFolder.Text);

                    // Kiểm tra xem thư mục đã tồn tại chưa
                    if (!Directory.Exists(playlistFolderPath))
                    {
                        // Nếu chưa tồn tại, tạo thư mục mới
                        Directory.CreateDirectory(playlistFolderPath);
                        txtFolder.Text = "";
                        DisplayFolder();
                    }
                    else
                    {
                        // Nếu thư mục đã tồn tại, hiển thị thông báo và trả về false
                        MessageBox.Show("Playlist đã tồn tại.");

                    }
                }
                catch (Exception ex)
                {
                    // Xử lý nếu có lỗi xảy ra khi tạo thư mục
                    MessageBox.Show($"Lỗi: {ex.Message}");

                }
            }
        }

        public string getPlaylistName()
        {
            return lblSelectedFolder.Text;
        }

        public void reloadPlaylis()
        {
            string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string playlistFolder = Path.Combine(dataFolderPath, "Playlist");
            string playlistFolderPath = Path.Combine(playlistFolder, lblSelectedFolder.Text);

            var songs = new List<Song>();
            string filePath = Path.Combine(playlistFolderPath, "songs.txt");

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 6)
                    {
                        var song = new Song
                        {
                            Title = parts[0],
                            Author = parts[1],
                            Artist = parts[2],
                            FilePath = Path.Combine(dataFolderPath, "Audio", parts[3]),
                            CoverPath = Path.Combine(dataFolderPath, "Images", parts[4]),

                            IsFavorite = parts[5] == "True" ? true : false,
                        };
                        songs.Add(song);
                    }
                }
            }

            flowLayoutPanelPlaylist.Controls.Clear();
            foreach (var song in songs)
            {
                allFolders = GetPlaylistNames();
                var songItemControl = new SongItemControl
                {
                    SongTitle = song.Title,
                    SongAuthor = song.Author,
                    SongArtist = song.Artist,
                    CoverPath = song.CoverPath,
                    SongPath = song.FilePath,
                    IsFavorite = song.IsFavorite,
                    FolderList = allFolders,
                    HideFolder = false,
                    HideDelete = true,

                    Width = flowLayoutPanelPlaylist.Width - 20 // Adjust the width as needed
                };
                songItemControl.SongItemClick += SongItemControl_SongItemClick;
                flowLayoutPanelPlaylist.Controls.Add(songItemControl);
            }
        }

        public void DisplayPlaylistDetail(string folderPlaylistName)
        {
            playlistPanel.Visible = true;
            historyPanel.Visible = false;
            searchPanel.Visible = false;
            favouritePanel.Visible = false;
            folderPanel.Visible = false;
            lblSelectedFolder.Text = folderPlaylistName;

            string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string playlistFolder = Path.Combine(dataFolderPath, "Playlist");
            string playlistFolderPath = Path.Combine(playlistFolder, folderPlaylistName);

            var songs = new List<Song>();
            string filePath = Path.Combine(playlistFolderPath, "songs.txt");

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 6)
                    {
                        var song = new Song
                        {
                            Title = parts[0],
                            Author = parts[1],
                            Artist = parts[2],
                            FilePath = Path.Combine(dataFolderPath, "Audio", parts[3]),
                            CoverPath = Path.Combine(dataFolderPath, "Images", parts[4]),

                            IsFavorite = parts[5] == "True" ? true : false,
                        };
                        songs.Add(song);
                    }
                }
            }

            flowLayoutPanelPlaylist.Controls.Clear();
            foreach (var song in songs)
            {
                allFolders = GetPlaylistNames();
                var songItemControl = new SongItemControl
                {
                    SongTitle = song.Title,
                    SongAuthor = song.Author,
                    SongArtist = song.Artist,
                    CoverPath = song.CoverPath,
                    SongPath = song.FilePath,
                    IsFavorite = song.IsFavorite,
                    FolderList = allFolders,
                    HideFolder = false,
                    HideDelete = true,
                    HideFavorite = false,

                    Width = flowLayoutPanelPlaylist.Width - 20 // Adjust the width as needed
                };
                songItemControl.SongItemClick += SongItemControl_SongItemClick;
                flowLayoutPanelPlaylist.Controls.Add(songItemControl);
            }
        }

        public List<string> GetPlaylistNames()
        {
            List<string> playlistNames = new List<string>();

            string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string playlistFolder = Path.Combine(dataFolderPath, "Playlist");

            try
            {
                if (Directory.Exists(playlistFolder))
                {
                    string[] playlistDirectories = Directory.GetDirectories(playlistFolder);
                    foreach (string playlistDirectory in playlistDirectories)
                    {
                        string playlistName = new DirectoryInfo(playlistDirectory).Name;
                        playlistNames.Add(playlistName);
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra khi lấy danh sách playlist
                Console.WriteLine($"Lỗi: {ex.Message}");
            }

            return playlistNames;
        }

        public void AddToDownloadHistory(SongItemControl songItem)
        {
            string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string downloadHistoryPath = Path.Combine(dataFolderPath, "download_history.txt");
            string songFileName = Path.GetFileName(songItem.SongPath);
            string coverFileName = Path.GetFileName(songItem.CoverPath);

            string songInfo = $"{songItem.SongTitle}|{songItem.SongAuthor}|{songItem.SongArtist}|{songFileName}|{coverFileName}|{DateTime.Now}";

            try
            {
                using (StreamWriter writer = new StreamWriter(downloadHistoryPath, true))
                {
                    writer.WriteLine(songInfo);
                }
                LoadDownloadHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving download history: {ex.Message}");
            }
        }

        private void LoadDownloadHistory()
        {
            string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string downloadHistoryPath = Path.Combine(dataFolderPath, "download_history.txt");

            try
            {
                flowLayoutPanelDownloads.Controls.Clear();

                if (File.Exists(downloadHistoryPath))
                {
                    string[] lines = File.ReadAllLines(downloadHistoryPath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 6)
                        {
                            var songItemControl = new SongItemControl
                            {
                                SongTitle = parts[0],
                                SongAuthor = parts[1],
                                SongArtist = parts[2],
                                CoverPath = Path.Combine(dataFolderPath, "Images", parts[4]),
                                SongPath = Path.Combine(dataFolderPath, "Audio", parts[3]),
                                TimeListen = parts[5],
                                HideFavorite = false,
                                HideDelete = false,
                                HideFolder = false,
                                HideDownload = false,
                                Width = flowLayoutPanelDownloads.Width - 20 // Adjust the width as needed
                            };
                            songItemControl.SongItemClick += SongItemControl_SongItemClick;
                            flowLayoutPanelDownloads.Controls.Add(songItemControl);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading download history: {ex.Message}");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            activePanel = "";
            SetActiveButton();
            LoadDownloadHistory();
            downloadPanel.Visible = true;
            playlistPanel.Visible = false;
            historyPanel.Visible = false;
            searchPanel.Visible = false;
            favouritePanel.Visible = false;
            folderPanel.Visible = false;
            lblTitle.Text = "";
        }

        private void panelCurrentPlaySong_Click(object sender, EventArgs e)
        {
            activePanel = "";
            SetActiveButton();
            detailPanel.Visible = true;
            downloadPanel.Visible = false;
            playlistPanel.Visible = false;
            historyPanel.Visible = false;
            searchPanel.Visible = false;
            favouritePanel.Visible = false;
            folderPanel.Visible = false;
            LoadComment();
            lblDetail.Text = currentSong.SongTitle;
            lblArtist.Text = currentSong.SongArtist;
            lblTitle.Text = "";
        }

        private void panelCurrentPlaySong_Click(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {

        }

        private void btnSendCommet_Click(object sender, EventArgs e)
        {
           if(txtComment.Text=="")
            {
                MessageBox.Show("Vui lòng nhập bình luận");
            }
            else
            {
                string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
                string downloadHistoryPath = Path.Combine(dataFolderPath, "comment.txt");


                string songInfo = $"{currentSong.SongTitle}|{txtComment.Text}|{DateTime.Now}";

                try
                {
                    using (StreamWriter writer = new StreamWriter(downloadHistoryPath, true))
                    {
                        writer.WriteLine(songInfo);
                    }
                    txtComment.Text = "";
                    LoadComment();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving download history: {ex.Message}");
                }
            }
        }

        public void LoadComment()
        {
            string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string downloadHistoryPath = Path.Combine(dataFolderPath, "comment.txt");

            try
            {
                flowLayoutPanelComment.Controls.Clear();

                if (File.Exists(downloadHistoryPath))
                {
                    string[] lines = File.ReadAllLines(downloadHistoryPath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 3)
                        {
                         

                            string songTitle = parts[0];

                            if(songTitle==currentSong.SongTitle)
                            {
                                var commentControl = new CommentControl
                                {
                                    Comment = parts[1],
                                    Time = parts[2]
                                };
                                flowLayoutPanelComment.Controls.Add(commentControl);

                            }    
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading download history: {ex.Message}");
            }
        }
    }
}
