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
    public partial class empSign_Log : Form
    {
        public empSign_Log()
        {
            InitializeComponent();
            empSignUp1.Hide();
            logIn1.Show();
            logIn1.state=1;
        }

        private void empSignUp1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            empSignUp1.Show();
        }
    }
}
