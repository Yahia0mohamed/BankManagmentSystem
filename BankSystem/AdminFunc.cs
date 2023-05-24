using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BankSystem
{
    public partial class AdminFunc : Form
    {
        public AdminFunc()
        {
            InitializeComponent();
            adminControls1.Hide();
            addBank1.Hide();
            addBranch1.Hide();
            adminControls1.instance = addBank1;
            adminControls1.addBranch = addBranch1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (code_txtbx.Text.ToString() == "500500")
            {
                adminControls1.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminFunc_Load(object sender, EventArgs e)
        {

        }

        private void adminControls1_Load(object sender, EventArgs e)
        {

        }
    }
}
