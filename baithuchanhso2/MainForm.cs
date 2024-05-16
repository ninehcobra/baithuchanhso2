using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace baithuchanhso2
{
    public partial class MainForm : Form
    {

        string activePanel = "Home";

        private List<Song> allSongs;
        private SongRepository songRepository;

        string placeholderSearch = "Bạn muốn nghe gì?";


        public MainForm()
        {
            InitializeComponent();
            flowLayoutPanelSongs.WrapContents = false;
            flowLayoutPanelSongs.FlowDirection = FlowDirection.TopDown;
            string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            songRepository = new SongRepository(dataFolderPath);
            LoadSongs();

            SetActiveButton();
            InitializeSearchTextBox();

            var genres = new List<string> { "Tất cả", "Pop", "Ballad", "Rap", "Indie" };
            comboBoxGenres.Items.AddRange(genres.ToArray());
            comboBoxGenres.SelectedIndex = 0;



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


            try
            {
                using (StreamWriter sw = new StreamWriter(historyFilePath, true))
                {
                    sw.WriteLine(songInfo);
                }
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
            SearchSongs(txtSearch.Text==placeholderSearch?"":txtSearch.Text);
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

        }

        private void DisplaySongs(List<Song> songs)
        {
            flowLayoutPanelSongs.Controls.Clear();
            foreach (var song in songs)
            {
                var songItemControl = new SongItemControl
                {
                    SongTitle = song.Title,
                    SongAuthor= song.Author,
                    SongArtist = song.Artist,
                    CoverPath = song.CoverPath,
                    SongPath= song.FilePath,

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
                panelCurrentPlaySong.Visible = true;
                 lblSongCurrentTitle.Text=songItem.SongTitle + " - "+ songItem.SongArtist;
                picCurrentPlaySong.Image=Image.FromFile(songItem.CoverPath);

                SaveSongToHistory(songItem);
            }
        }

        public void SetActiveButton()
        {
            if (activePanel == "Home")
            {
                lblTitle.Text = "Trang Chủ";
                lblHome.ForeColor = ColorTranslator.FromHtml("#f5f5f5");
                picHome.Image = ButtonImage.home_active;


                lblLibrary.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picLibrary.Image = ButtonImage.library_normal;
                lblSearch.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picSearch.Image = ButtonImage.search_normal;
                lblHistory.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHistory.Image = ButtonImage.history_normal;

                searchPanel.Visible = false;
            }
            else if (activePanel == "Search")
            {
                lblTitle.Text = "Tìm kiếm";
                lblSearch.ForeColor = ColorTranslator.FromHtml("#f5f5f5");
                picSearch.Image = ButtonImage.search_active;

                lblHome.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHome.Image = ButtonImage.home_normal;
                lblLibrary.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picLibrary.Image = ButtonImage.library_normal;
                lblHistory.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHistory.Image = ButtonImage.history_normal;

                searchPanel.Visible = true;
            }
            else if (activePanel == "Library")
            {
                lblTitle.Text = "Thư viện";
                lblLibrary.ForeColor = ColorTranslator.FromHtml("#f5f5f5");
                picLibrary.Image = ButtonImage.library_active;

                lblHome.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHome.Image = ButtonImage.home_normal;
                lblSearch.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picSearch.Image = ButtonImage.search_normal;
                lblHistory.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHistory.Image = ButtonImage.history_normal;

                searchPanel.Visible = false;
            }
            else if (activePanel == "History")
            {
                lblTitle.Text = "Lịch sử";

                lblHistory.ForeColor = ColorTranslator.FromHtml("#f5f5f5");
                picHistory.Image = ButtonImage.history_active;

                lblHome.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHome.Image = ButtonImage.home_normal;
                lblLibrary.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picLibrary.Image = ButtonImage.library_normal;
                lblSearch.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picSearch.Image = ButtonImage.search_normal;

                searchPanel.Visible = false;


            }
            else if (activePanel == "")
            {
                lblHome.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHome.Image = ButtonImage.home_normal;
                lblLibrary.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picLibrary.Image = ButtonImage.library_normal;
                lblSearch.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picSearch.Image = ButtonImage.search_normal;
                lblHistory.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHistory.Image = ButtonImage.history_normal;

                searchPanel.Visible = false;
            }
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
           if(keyword !=placeholderSearch)
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
    }
}
