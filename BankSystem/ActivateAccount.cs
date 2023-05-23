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
    public partial class ActivateAccount : UserControl
    {
        public Employee employee { get; set; }
        BankSystemControler b;
        public ActivateAccount()
        {
            InitializeComponent();
            b = new BankSystemControler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b.ActivateCustomer(SSN_txtBX.Text.ToString(),branch_txtBX.Text.ToString());
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
