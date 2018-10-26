using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    public static class TextValidator
    {
        public static void IsAlphabet(ref string value, string programTitle)
        {
            for(int i=0; i<value.Length; i++)
            {
                char c = Convert.ToChar(value[i]);

                if (Char.IsLetter(c) == false)
                {
                    MessageBox.Show("Only Alphabets are Allowed.", programTitle);

                    value = value.Remove(i, 1);
                }
            }
        }

    }
}
