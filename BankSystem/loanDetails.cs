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
    public partial class loanDetails : UserControl
    {
        public Employee emp;
        public loanDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog = myBankSystem; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select e.name as employeeName ,c.name as CustomerName , l.amount,l.loanID from customer as c " +
                "join loan as l " +
                "on c.ssn=l.ssn " +
                "join employee as e " +
                "on e.employeeID=l.employeeID and e.branchID='" + emp.BranchID + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
