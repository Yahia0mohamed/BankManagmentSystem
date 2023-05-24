using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "Update Customer set branchID='" + branch_txtBX.Text.ToString() + "' where SSN='" + SSN_txtBX.Text.ToString() + "';";
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=myBankSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            int rows =cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("activated " + rows + "account/s");
            this.Hide();
        }
    }
}
