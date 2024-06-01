using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplicationYumol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Item cs;
        private void ComputeButton_Click(object sender, EventArgs e)
        {
            cs = new Item(ItemTextBox.Text, Convert.ToDouble(PriceTextBox.Text), Convert.ToInt16(QuantityTextBox.Text), Convert.ToDouble(DiscountTextBox.Text));

            TotalAmount.Text = cs.GetTotalPrice().ToString();


        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            cs.setPayment(Convert.ToDouble(PaymentTextBox.Text));
            Change.Text = cs.GetChange().ToString();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLoginAccount frmLoginAccount = new frmLoginAccount();
            frmLoginAccount.Show();

            this.Hide();
        }
    }
}