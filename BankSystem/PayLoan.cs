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
    public partial class PayLoan : UserControl
    {
        public Employee emp;
        public int id;
        private BankSystemControler b;
        public PayLoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog = myBankSystem; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from loan where loan.branchID='" + emp.BranchID + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog = myBankSystem; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from loan where Loanid='" + id_txtBX.Text.ToString() + "';", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("payed");
        }
    }
}
