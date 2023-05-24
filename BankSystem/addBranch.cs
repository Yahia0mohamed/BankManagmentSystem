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
    public partial class addBranch : UserControl
    {
        public addBranch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=myBankSystem;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into branch values ('" + branchID_txtBX.Text.ToString() + "','" + Address_txtBX.Text.ToString() + "','" + bankID_txtBX.Text.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("added succefully");
            this.Hide();

        }
    }
}
