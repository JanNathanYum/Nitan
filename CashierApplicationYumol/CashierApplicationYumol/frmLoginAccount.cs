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
    public partial class frmLoginAccount : Form
    {
        static Form1 frmPurchaseDiscountedItem = new Form1();


        public frmLoginAccount()
        {
            InitializeComponent();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {

            Cashier cashier = new Cashier("Clarissa Castro", "Finance", UserNameTextBox.Text, PasswordTextBox.Text);

            if (cashier.validateLogin(UserNameTextBox.Text, PasswordTextBox.Text))
            {
                MessageBox.Show($"Welcome  {cashier.getFullName()}  of  {cashier.getDepartment()}");
                frmPurchaseDiscountedItem.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credentials Invalid");
            }
        }
    }
}