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


    public partial class AccRejLoan : UserControl
    {
        public Employee emp;
        public int id;
        private BankSystemControler b;
        public AccRejLoan()
        {
            InitializeComponent();
            b = new BankSystemControler();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog = myBankSystem; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select loanType,amount,SSN,e.branchID,employeeID from loanWaitingList as l  join employee as e  on e.branchID=l.branchID  and e.employeeID='" + emp.EmployeeID + "' where l.id='" + int.Parse(id_txtBX.Text.ToString()) + "';", con);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                string id = b.generateID(10);
                cmd = new SqlCommand("insert into loan values('" + id + "','" + r.GetString(0) + "','" + r.GetDouble(1) + "','" + r.GetString(2) + "','" + r.GetString(3) + "','" + r.GetString(4) + "');", con);
                r.Close();
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("done " + rows);
                cmd = new SqlCommand("delete from loanwaitinglist where id='" + int.Parse(id_txtBX.Text.ToString()) + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("non found");
                r.Close();
                con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog = myBankSystem; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from loanwaitinglist where id='" + int.Parse(id_txtBX.Text.ToString()) + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("rejected");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog = myBankSystem; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select id,amount,customername,SSN from loanwaitinglist where loanwaitinglist.branchID='" + emp.BranchID + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void id_txtBX_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
