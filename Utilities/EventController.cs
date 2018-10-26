using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Utilities
{
    public class EventController : Form
    {
        public void _FormClosing(object sender, FormClosingEventArgs e, string _programTitle)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                dynamic dialogResult = MessageBox.Show("Are you Really Want to Quit.", _programTitle,
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    e.Cancel = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
