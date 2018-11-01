using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _IdeaBagApp.Categories
{
    public partial class Numbers : Form
    {
        public Form RefToMainMenu { get; set; }

        public Numbers()
        {
            InitializeComponent();
        }

        private void Numbers_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RefToMainMenu.Show();
        }
    }
}
