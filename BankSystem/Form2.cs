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
    public partial class Form2 : Form
    {
        BankSystemControler b;
        public static Form2 Instance;
        public Form2()
        {
            InitializeComponent();
            Instance = this;
            b=new BankSystemControler("Data Source=.;Initial Catalog=myBankSystem;Integrated Security=True");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            
            
        }
    }
}
