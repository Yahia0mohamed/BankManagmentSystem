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
    public partial class adminControls : UserControl
    {
        public addBank instance { get; set; }
        public addBranch addBranch { get; set; }

        public adminControls()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportForm newwin= new reportForm();
            newwin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addBranch.Hide();
            instance.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            instance.Hide();
            addBranch.Show();
        }
    }
}
