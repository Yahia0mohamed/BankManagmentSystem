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
    public partial class loanRequest : UserControl
    {
        BankSystemControler b;
        public loanRequest()
        {
            InitializeComponent();
            b = new BankSystemControler();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            b.RequestLoan(SSN_txtBX.Text.ToString(), LType_txtBX.Text.ToString(), BID_txtBX.Text.ToString(), double.Parse(amount_txtBX.Text));

            this.Hide();
        }
    }
}
