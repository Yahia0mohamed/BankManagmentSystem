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
    public partial class SignUp : UserControl
    {
        SignUp instance;
        BankSystemControler b;
        public SignUp()
        {
            instance = this;
            InitializeComponent();
            b = new BankSystemControler();
            pass_txtBX.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Ssn = SSN_txtBX.Text.ToString();
            customer.Name = name_txtBX.Text.ToString();
            customer.Phone = phone_txtBX.Text.ToString();
            customer.Address = address_txtBX.Text.ToString();
            customer.UserName = user_txtBX.Text.ToString();
            customer.Password = pass_txtBX.Text.ToString();
            b.SaveUser(customer);
            MessageBox.Show("customer added succesfully");
            SSN_txtBX.ResetText();
            name_txtBX.ResetText();
            phone_txtBX.ResetText();
            address_txtBX.ResetText();
            user_txtBX.ResetText();
            pass_txtBX.ResetText();
            instance.Hide();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
