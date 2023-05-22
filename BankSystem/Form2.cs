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
    public partial class Form2 : Form
    {

        public static Form2 Instance;
        public Form2()
        {
            InitializeComponent();
            Instance = this;
            signUp1.Hide();
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
    }
}
