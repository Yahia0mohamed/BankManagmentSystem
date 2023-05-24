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
    public partial class Loanoptions : Form
    {
        public Employee employee;
        public Loanoptions()
        {
            InitializeComponent();
            accRejLoan1.Hide();
            payLoan1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            payLoan1.Hide();
            accRejLoan1.emp = employee;
            accRejLoan1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            accRejLoan1.Hide();
            payLoan1.emp = employee;
            payLoan1.Show();
        }
    }
}
