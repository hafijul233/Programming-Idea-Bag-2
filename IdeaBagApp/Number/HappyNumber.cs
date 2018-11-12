using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;

namespace _IdeaBagApp.Number
{
    public partial class HappyNumber : Form
    {
        [DllImport("gdi32.dll")]
        public static extern IntPtr AddFontMemresourceEx(IntPtr pbfont, uint cbfont,
                                                        IntPtr pdv, [In] ref uint pcFonts);
        public FontFamily ff;
        public Font font;

        private const string _programTitle = "Happy Numbers";
        private int proof = 0;

        public HappyNumber()
        {
            InitializeComponent();
            //LoadFont();
            //AllocateFont(font, this.ReplyLabel,12);
        }

        public void LoadFont()
        {
            byte[] fontArray = _IdeaBagApp.Properties.Resources.heydings_icons;
            int datalength = _IdeaBagApp.Properties.Resources.heydings_icons.Length;

            IntPtr ptrData = Marshal.AllocCoTaskMem(datalength);

            Marshal.Copy(fontArray, 0, ptrData, datalength);

            uint cFonts = 0;
            AddFontMemresourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();

            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];

            font = new Font(ff, 15f, FontStyle.Bold); 
        }

        private void AllocateFont (Font f, Control c, float size)
        {
            FontStyle fontStyle = FontStyle.Bold;
            c.Font = new Font(ff, 20, fontStyle);
        }

        private void FindHappyNumber(string TestNumber)
        {
            uint digit = 0, square = 0;

            if (TestNumber.Length == 1)
            {
                if (TestNumber == "1" || TestNumber == "0") proof = 1;

                else proof = 0;

            }

            else
            {
                ulong squareSum = 0;

                foreach (char c in TestNumber)
                {
                    digit = Convert.ToUInt32(c) - 48;
                    square = digit * digit;
                    squareSum = squareSum + square;
                }

                TestNumber = Convert.ToString(squareSum);

                FindHappyNumber(TestNumber);
            }
        }

        private void InputNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = InputNumberTextBox.Text;

            foreach (char c in temp)
            {
                if (Char.IsDigit(c) == false)
                {
                    MessageBox.Show("Only NUmbers are Allowed.", _programTitle);
                }
            }

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string inputValue = InputNumberTextBox.Text;

            if (inputValue == String.Empty)
            {
                ReplyLabel.Text = "Input value is Empty.";
            }

            else
            {

                FindHappyNumber(inputValue);

                InputNumberTextBox.Text = String.Empty;

                if (proof == 1)
                    ReplyLabel.Text = inputValue + " is a Happy Number.";

                else
                    ReplyLabel.Text = inputValue + " is a Sad Number.";
            }
        }
    }
}
