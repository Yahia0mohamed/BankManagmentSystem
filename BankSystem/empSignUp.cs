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
    public partial class empSignUp : UserControl
    {
        BankSystemControler b;
        public empSignUp()
        {
            InitializeComponent();
            b = new BankSystemControler();
            pass_txtBX.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Name = name_txtBX.Text.ToString();
            emp.BranchID = branchID_txtBX.Text.ToString();
            emp.UserName = user_txtBX.Text.ToString();
            emp.Password = pass_txtBX.Text.ToString();
            b.SaveEmp(emp);
            MessageBox.Show("employee added succefully");
            this.Hide();
        }
    }
}
