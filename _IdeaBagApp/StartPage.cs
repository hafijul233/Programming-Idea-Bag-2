using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _IdeaBagApp
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void StartPageForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startingProgressBar.Increment(1);
            if(startingProgressBar.Value == 100)
            {
                timer1.Stop();
                MainMenu mainMenuForm = new MainMenu();
                    Hide();
                mainMenuForm.Show();
            }
        }
    }
}
