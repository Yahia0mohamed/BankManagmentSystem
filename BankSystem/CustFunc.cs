using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class CustFunc : Form
    {
        public Customer Customer { get; set; }
        BankSystemControler b;
        public CustFunc(Customer c)
        {
            InitializeComponent();
            b = new BankSystemControler();
            loanTypes1.Hide();
            loanRequest1.Hide();
            Customer = c;
            label1.Text = Customer.Name;
            label2.Text = Customer.Address;
            label3.Text = Customer.BranchID;
            if (Customer.BranchID != null)
            {
                stateLBL.Text = "inactive";
                label3.Text = "not connected";
            }
            else { stateLBL.Text = "active"; }
            label4.Text = Customer.Phone;
            label5.Text = Customer.UserName;
        }

        private void loanRequest1_Load(object sender, EventArgs e)
        {

        }

        private void RequestLoan_Click(object sender, EventArgs e)
        {
            if (stateLBL.Text == "inactive")
            {
                loanRequest1.Hide();
                MessageBox.Show("inactive account can't request loan");
            }
            else
            {
                loanTypes1.Hide();
                loanRequest1.Show();
            }

        }

        private void ShowLoanTypes_Click(object sender, EventArgs e)
        {
            loanRequest1.Hide();
            loanTypes1.Show();
        }

        private void loanTypes1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bar1_Load(object sender, EventArgs e)
        {

        }
    }
}
