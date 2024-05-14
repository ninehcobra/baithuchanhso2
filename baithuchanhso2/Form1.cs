using System;
using System.Drawing;
using System.Windows.Forms;

namespace baithuchanhso2
{
    public partial class Form1 : Form
    {

        string activePanel = "";
        public Form1()
        {
            InitializeComponent();


        }

        public void SetActiveButton()
        {
            if (activePanel == "Home")
            {
                lblHome.ForeColor = ColorTranslator.FromHtml("#f5f5f5");
                picHome.Image = ButtonImage.home_active;


                lblLibrary.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picLibrary.Image = ButtonImage.library_normal;
                lblSearch.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picSearch.Image = ButtonImage.search_normal;
                lblHistory.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHistory.Image = ButtonImage.history_normal;
            }
            else if (activePanel == "Search")
            {
                lblSearch.ForeColor = ColorTranslator.FromHtml("#f5f5f5");
                picSearch.Image = ButtonImage.search_active;

                lblHome.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHome.Image = ButtonImage.home_normal;
                lblLibrary.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picLibrary.Image = ButtonImage.library_normal;
                lblHistory.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHistory.Image = ButtonImage.history_normal;
            }
            else if (activePanel == "Library")
            {
                lblLibrary.ForeColor = ColorTranslator.FromHtml("#f5f5f5");
                picLibrary.Image = ButtonImage.library_active;

                lblHome.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHome.Image = ButtonImage.home_normal;
                lblSearch.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picSearch.Image = ButtonImage.search_normal;
                lblHistory.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHistory.Image = ButtonImage.history_normal;
            }
            else if (activePanel == "History")
            {
                lblHistory.ForeColor = ColorTranslator.FromHtml("#f5f5f5");
                picHistory.Image = ButtonImage.history_active;

                lblHome.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picHome.Image = ButtonImage.home_normal;
                lblLibrary.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picLibrary.Image = ButtonImage.library_normal;
                lblSearch.ForeColor = ColorTranslator.FromHtml("#b4b4b4");
                picSearch.Image = ButtonImage.search_normal;

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
                activePanel = "";
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
                activePanel = "";
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
                activePanel = "";
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
                activePanel = "";
            }

            SetActiveButton();
        }
    }
}
