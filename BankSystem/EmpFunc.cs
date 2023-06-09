﻿using System;
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
    public partial class form : Form
    {
        Employee employee;
        public form(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            userName.Text = employee.UserName;
            Name.Text = employee.Name;
            branchID.Text = employee.BranchID;
            signUp1.Hide();
            activateAccount1.Hide();
            viewUsers1.Hide();
            signUp1.branchID = this.employee.BranchID;
            viewUsers1.emp = employee;
            loanDetails1.Hide();
            loanDetails1.emp = employee;
            activateAccount1.employee = employee;


        }

        private void EmpFunc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            signUp1.Hide();
            viewUsers1.Hide();
            activateAccount1.Show();
            loanDetails1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loanDetails1.Hide();
            activateAccount1.Hide();
            viewUsers1.Hide();
            signUp1.Show();
            
        }

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loanDetails1.Hide();
            signUp1.Hide();
            activateAccount1.Hide();
            viewUsers1.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Loanoptions newwin = new Loanoptions();
            newwin.employee = employee;
            newwin.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            signUp1.Hide();
            activateAccount1.Hide();
            viewUsers1.Hide();
            loanDetails1.Show();
        }
    }
}
