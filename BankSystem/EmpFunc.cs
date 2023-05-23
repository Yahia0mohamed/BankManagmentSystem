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
    public partial class EmpFunc : Form
    {
        Employee employee;
        public EmpFunc(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            userName.Text = employee.UserName;
            Name.Text = employee.Name;
            branchID.Text = employee.BranchID;
        }

        private void EmpFunc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void userName_Click(object sender, EventArgs e)
        {

        }
    }
}
