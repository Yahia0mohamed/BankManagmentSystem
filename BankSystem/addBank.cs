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
    public partial class addBank : UserControl
    {
        public addBank()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog = myBankSystem; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("insert into bank values ('"+name_txtBX.Text.ToString()+"','"+Address_txtBX.Text.ToString()+"','"+bankID_txtBX.Text.ToString()+"','"+branchNum_txtBX.Text.ToString()+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("added succefully");
            this.Hide();

        }
    }
}
