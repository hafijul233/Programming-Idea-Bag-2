using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Numbers.ChangeReturn.BLL;
using Numbers.ChangeReturn.Models;

namespace Numbers.ChangeReturn.UI
{
    public partial class ChangeReturnApp : Form
    {
        public ChangeReturnController _crpController = new ChangeReturnController();

        public List<CRPItem> _StockItemList = new List<CRPItem>();

        public List<CRPItem> _SellingItemList = new List<CRPItem>();

        private double _totalPrize;

        private double _taxPrize;

        public ChangeReturnApp()
        {
            InitializeComponent();
        }

        private void ChangeReturnApp_Load(object sender, EventArgs e)
        {
            foreach (string itemName in _crpController.itemsNameList)
            {
                ItemsListComboBox.Items.Add(itemName);
            }

            foreach (CRPItem item in _crpController.crpItems.CrpItemsDbList)
            {
                _StockItemList.Add(item);
            }
        }

        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (customerNameTextBox.Text != String.Empty)
            {
                string temp = customerNameTextBox.Text;

                foreach (char c in temp)
                {
                    if (Char.IsLetter(c) == false)
                    {
                        MessageBox.Show("Only Alphabet Are Allowed.");
                    }
                }
            }
        }

        private void customerIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (customerIdTextBox.Text != String.Empty)
            {
                string temp = customerIdTextBox.Text;

                foreach (char c in temp)
                {
                    if (Char.IsDigit(c) == false)
                    {
                        MessageBox.Show("Only Numbers Are Allowed.");
                    }
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CRPItem newItem = new CRPItem();

            newItem.Name = ItemsListComboBox.Text;
            newItem.Quantity = Convert.ToDouble(QtyTextBox.Text);

            for (int i = 0; i < _StockItemList.Count; i++)
            {
                if (_StockItemList[i].Name.Contains(newItem.Name))
                {
                    newItem.Id = _StockItemList[i].Id;
                    newItem.Unitprize = _StockItemList[i].Unitprize;
                    break;
                }
            }

            newItem.TotalPrize = newItem.Unitprize * newItem.Quantity;

            _SellingItemList.Add(newItem);

            EntryProductlistView.Items.Clear();
            int counter = 1;
            foreach (CRPItem item in _SellingItemList)
            {
                EntryProductlistView.Items.Add(new ListViewItem(new string[]
                {
                    counter.ToString(),item.Id.ToString(), item.Name, item.Quantity.ToString(), item.Unitprize.ToString(),
                    item.TotalPrize.ToString()
                }));
                counter++;
            }

            _totalPrize = 0.0;


            foreach (CRPItem item in _SellingItemList)
            {
                _totalPrize += item.TotalPrize;
            }

            _taxPrize = (_totalPrize / 100) * 15.025;

            totalPrizeLabel.Text = String.Format("{0:F2}", _totalPrize);
            taxLabel.Text = String.Format("{0:F2}", _taxPrize);

            _totalPrize += _taxPrize;
            totalPaymentLabel.Text = String.Format("{0:F2}", _totalPrize);
        }

        private void ReceiveTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ReceiveTextBox.Text != String.Empty)
            {
                double ReceivedPay = Convert.ToDouble(ReceiveTextBox.Text);
                /*if (ReceivedPay < _totalPrize)
                {
                    var dialogResult = MessageBox.Show("Payment Is Insuffcient to Recceive.", "Change Return Program",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Cancel)
                    {
                        ReceiveTextBox.Text = "";
                    }
                }
                else
                {*/
                    int changeReturn = (int)(ReceivedPay - _totalPrize);
                    ChangeReturnLabel.Text = String.Format("{0:F2}", changeReturn);

                    Return_1000Label.Text = Convert.ToString(changeReturn / 1000);
                    changeReturn %= 1000;

                    Return_500Label.Text = Convert.ToString(changeReturn / 500);
                    changeReturn %= 500;

                    Return_100Label.Text = Convert.ToString(changeReturn / 100);
                    changeReturn %= 100;

                    Return_50Label.Text = Convert.ToString(changeReturn / 50);
                    changeReturn %= 50;

                    Return_20Label.Text = Convert.ToString(changeReturn / 20);
                    changeReturn %= 20;

                    Return_10Label.Text = Convert.ToString(changeReturn / 10);
                    changeReturn %= 10;

                    Return_5Label.Text = Convert.ToString(changeReturn / 5);
                    changeReturn %= 5;

                    Return_2Label.Text = Convert.ToString(changeReturn / 2);
                    changeReturn %= 2;

                    Return_1Label.Text = Convert.ToString(changeReturn / 1);
                    changeReturn %= 1;
                //}
            }
        }

        private void ChangeReturnApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic dialogResult = MessageBox.Show("Are you Really Want to Exit", Properties.Resources.programTitle,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
