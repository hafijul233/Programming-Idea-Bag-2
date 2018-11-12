using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _IdeaBagApp.Categories;
using Utilities;

namespace _IdeaBagApp
{
    public partial class MainMenu : Form
    {
        EventController eventController = new EventController();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            eventController._FormClosing(sender, e, "Programming Idea Bag");
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            Numbers numbersPage = new Numbers();
            numbersPage.RefToMainMenu = this;
            this.Hide();
            numbersPage.Show();
        }

        private void textButton_Click(object sender, EventArgs e)
        {
            Text textPage = new Text();
            this.Hide();
            textPage.Show();
        }

        private void networkingButton_Click(object sender, EventArgs e)
        {
            Networking networkingPage = new Networking();
            this.Hide();
            networkingPage.Show();
        }

        private void enterpriseButton_Click(object sender, EventArgs e)
        {
            EnterpriseApp enterpriseAppPage = new EnterpriseApp();
            this.Hide();
            enterpriseAppPage.Show();

        }

        private void threadingbutton_Click(object sender, EventArgs e)
        {
            Threading threadingPage = new Threading();
            this.Hide();
            threadingPage.Show();
        }

        private void webButton_Click(object sender, EventArgs e)
        {
            Web webPage = new Web();
            this.Hide();
            webPage.Show();
        }

        private void filesButton_Click(object sender, EventArgs e)
        {
            Files filesPage = new Files();
            this.Hide();
            filesPage.Show();
        }

        private void databasebutton_Click(object sender, EventArgs e)
        {
            Database databasePage = new Database();
            databasePage.RefToMainMenu = this;
            this.Hide();
            databasePage.Show();
        }

        private void multimediaButton_Click(object sender, EventArgs e)
        {
            Multimedia multimediaPage = new Multimedia();
            this.Hide();
            multimediaPage.Show();
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            Game gamePage = new Game();
            this.Hide();
            gamePage.Show();
        }

        private void hardwareButton_Click(object sender, EventArgs e)
        {
            Hardware hardwarePage = new Hardware();
            this.Hide();
            hardwarePage.Show();

        }

        private void otherButton_Click(object sender, EventArgs e)
        {
            Other otherPage = new Other();
            this.Hide();
            otherPage.Show();
        }
    }
}
