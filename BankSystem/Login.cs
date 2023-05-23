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
    public partial class LogIn : UserControl
    {
        BankSystemControler b;
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public int state { get; set; }
        public LogIn()
        {
            InitializeComponent();
            b = new BankSystemControler();
            pass_txtBX.PasswordChar = '*';
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (this.state == 0)
            {
                string username = user_txtBX.Text.ToString();
                string pass = pass_txtBX.Text.ToString();
                Customer myCustomer = b.LoadCustomer(username, pass);
                if (myCustomer.Name == null)
                {
                    MessageBox.Show("no user found");
                }
                else
                {
                    user_txtBX.ResetText();
                    pass_txtBX.ResetText();
                    this.Customer = myCustomer;
                    CustFunc newWin = new CustFunc(Customer);
                    newWin.Show();

                }
            }
            else
            {
                string username = user_txtBX.Text.ToString();
                string pass = pass_txtBX.Text.ToString();
                Employee emp = b.LoadEmployee(username, pass);
                if (emp.Name == null)
                {
                    MessageBox.Show("no user found");
                }
                else
                {
                    user_txtBX.ResetText();
                    pass_txtBX.ResetText();
                    this.Employee = emp;
                    EmpFunc newWin = new EmpFunc(Employee);
                    newWin.Show();

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
