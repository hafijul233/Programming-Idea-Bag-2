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

namespace _IdeaBagApp.Categories
{
    public partial class Database : Form
    {
        public Form RefToMainMenu { get; set; }

        public Database()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //eventController._ButtonFormClosing(sender, e, "Programming Idea Bag");
        }

        private void Database_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RefToMainMenu.Show();

        }
    }
}
