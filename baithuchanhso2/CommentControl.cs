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
    public partial class CommentControl : UserControl
    {
        public CommentControl()
        {
            InitializeComponent();
        }

        private string comment;
        private string time;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            List<string> historyLines = new List<string>();
            string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string downloadHistoryPath = Path.Combine(dataFolderPath, "comment.txt");
            try
            {
                // Đọc các dòng từ tệp lịch sử
                if (File.Exists(downloadHistoryPath))
                {
                    historyLines = File.ReadAllLines(downloadHistoryPath).ToList();
                }

                // Xóa bản ghi trùng lặp
                historyLines.RemoveAll(line => line.Split('|')[2] == this.time);

            

                // Ghi lại danh sách lịch sử vào tệp
                File.WriteAllLines(downloadHistoryPath, historyLines);

                var mainForm = this.ParentForm as MainForm;
                if (mainForm != null)
                {
                    mainForm.LoadComment();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error delete comment: {ex.Message}");
            }
        }

        public string Time
        {
            get { return time; }
            set { time = value; lblTime.Text =time; }
        }

        public string Comment
        {
            get { return comment; }
            set
            {
                comment = value;
                lblComment.Text = comment;
            }
        }
    }
}
