using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Utilities;

namespace _IdeaBagApp
{
    public partial class MainMenuForm : Form
    {
        EventController eventController = new EventController();

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            eventController._FormClosing(sender, e, "Programming Idea Bag");
        }
    }
}
