using Microsoft.VisualBasic;
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
    public partial class CustSign_Log : Form
    {

        public static CustSign_Log Instance;
        public CustSign_Log()
        {

            InitializeComponent();
            Instance = this;
            signUp1.Hide();
            logIn2.state = 0;
            logIn2.Show();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            signUp1.Show();
            
        }

        private void signUp1_Load(object sender, EventArgs e)
        {

        }

        private void logIn2_Load(object sender, EventArgs e)
        {

        }
    }
}
