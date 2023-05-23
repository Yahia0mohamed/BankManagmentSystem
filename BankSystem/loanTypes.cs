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
    public partial class loanTypes : UserControl
    {
        BankSystemControler b;
        public loanTypes()
        {
            b = new BankSystemControler();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataGridView GetDataGridView1()
        {
            return dataGridView1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1= b.getLoanTypes();
            dataGridView1.Show();
        }
    }
}
