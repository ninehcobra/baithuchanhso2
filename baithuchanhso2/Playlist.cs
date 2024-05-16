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
    public partial class Playlist : UserControl
    {
        public Playlist()
        {
            InitializeComponent();
        }

        private string playlistName;

        public string PlaylistName
        {
            get { return playlistName; }
            set
            {
                playlistName = value;
                lblFolder.Text = playlistName;
            }
        }

        public bool DeletePlaylist(string playlistName)
        {
            try
            {
                string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
                string playlistFolder = Path.Combine(dataFolderPath, "Playlist");
                string playlistFolderPath = Path.Combine(playlistFolder, playlistName);

                if (Directory.Exists(playlistFolderPath))
                {
                    Directory.Delete(playlistFolderPath, true);
                    MessageBox.Show("Xóa thành công");
                    var mainForm = this.ParentForm as MainForm;
                    if (mainForm != null)
                    {
                        mainForm.DisplayFolder();
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra khi xóa thư mục
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DeletePlaylist(playlistName);
        }

        public bool DeleteAllFilesAndSubfolders(string playlistName)
        {
            try
            {
                string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
                string playlistFolder = Path.Combine(dataFolderPath, "Playlist");
                string playlistFolderPath = Path.Combine(playlistFolder, playlistName);

                if (Directory.Exists(playlistFolderPath))
                {
                    // Xóa tất cả các tệp trong thư mục playlist
                    string[] files = Directory.GetFiles(playlistFolderPath);
                    foreach (string file in files)
                    {

                        File.Delete(file);
                    }

                    // Xóa tất cả các thư mục con
                    string[] subfolders = Directory.GetDirectories(playlistFolderPath);
                    foreach (string subfolder in subfolders)
                    {
                        DeleteAllFilesAndSubfolders(subfolder); // Sử dụng đệ quy để xóa các thư mục con
                    }

                    // Xóa thư mục playlist sau khi đã xóa tất cả các tệp và thư mục con

                    MessageBox.Show("Đã xóa hết danh sách bài hát trong playlist");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra khi xóa tệp và thư mục con
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DeleteAllFilesAndSubfolders(playlistName);
        }

        private void Playlist_Click(object sender, EventArgs e)
        {
            var mainForm = this.ParentForm as MainForm;
            if (mainForm != null) {
                mainForm.DisplayPlaylistDetail(playlistName);
            }
        }
    }
}
