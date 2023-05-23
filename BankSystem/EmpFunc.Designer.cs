namespace BankSystem
{
    partial class form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            panel1 = new Panel();
            button9 = new Button();
            label1 = new Label();
            button8 = new Button();
            panel3 = new Panel();
            branchID = new Label();
            Name = new Label();
            userName = new Label();
            button1 = new Button();
            panel2 = new Panel();
            button7 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button4 = new Button();
            button5 = new Button();
            signUp1 = new SignUp();
            activateAccount1 = new ActivateAccount();
            viewUsers1 = new ViewUsers();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(button9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(branchID);
            panel1.Controls.Add(Name);
            panel1.Controls.Add(userName);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 41);
            panel1.TabIndex = 0;
            // 
            // button9
            // 
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(3, 6);
            button9.Name = "button9";
            button9.Size = new Size(33, 29);
            button9.TabIndex = 3;
            button9.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(744, 12);
            label1.Name = "label1";
            label1.Size = new Size(54, 18);
            label1.TabIndex = 7;
            label1.Text = "HOME";
            // 
            // button8
            // 
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(703, 2);
            button8.Name = "button8";
            button8.Size = new Size(35, 37);
            button8.TabIndex = 3;
            button8.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(247, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(32, 34);
            panel3.TabIndex = 6;
            // 
            // branchID
            // 
            branchID.AutoSize = true;
            branchID.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            branchID.ForeColor = Color.Black;
            branchID.Location = new Point(485, 9);
            branchID.Name = "branchID";
            branchID.Size = new Size(62, 21);
            branchID.TabIndex = 5;
            branchID.Text = "label3";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Name.ForeColor = Color.Black;
            Name.Location = new Point(370, 9);
            Name.Name = "Name";
            Name.Size = new Size(93, 21);
            Name.TabIndex = 4;
            Name.Text = "EmpFunc";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            userName.ForeColor = Color.Black;
            userName.Location = new Point(285, 9);
            userName.Name = "userName";
            userName.Size = new Size(62, 21);
            userName.TabIndex = 3;
            userName.Text = "label1";
            userName.Click += userName_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(607, 67);
            button1.Name = "button1";
            button1.Size = new Size(153, 29);
            button1.TabIndex = 2;
            button1.Text = "Activate Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(618, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(132, 398);
            panel2.TabIndex = 1;
            // 
            // button7
            // 
            button7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(25, 354);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 8;
            button7.Text = "Pay Loan";
            button7.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(25, 15);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Add User";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(25, 73);
            button3.Name = "button3";
            button3.Size = new Size(94, 46);
            button3.TabIndex = 4;
            button3.Text = "View Users";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(25, 299);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 7;
            button6.Text = "Reject Loan";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(25, 137);
            button4.Name = "button4";
            button4.Size = new Size(94, 49);
            button4.TabIndex = 5;
            button4.Text = "View Waiting List";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(25, 212);
            button5.Name = "button5";
            button5.Size = new Size(94, 56);
            button5.TabIndex = 6;
            button5.Text = "Accept Loan";
            button5.UseVisualStyleBackColor = true;
            // 
            // signUp1
            // 
            signUp1.BackColor = Color.Transparent;
            signUp1.branchID = null;
            signUp1.Location = new Point(12, 44);
            signUp1.Name = "signUp1";
            signUp1.Size = new Size(379, 472);
            signUp1.TabIndex = 3;
            // 
            // activateAccount1
            // 
            activateAccount1.BackColor = Color.Transparent;
            activateAccount1.employee = null;
            activateAccount1.Location = new Point(12, 44);
            activateAccount1.Name = "activateAccount1";
            activateAccount1.Size = new Size(312, 145);
            activateAccount1.TabIndex = 4;
            // 
            // viewUsers1
            // 
            viewUsers1.BackColor = Color.Transparent;
            viewUsers1.emp = null;
            viewUsers1.Location = new Point(12, 111);
            viewUsers1.Name = "viewUsers1";
            viewUsers1.Size = new Size(361, 286);
            viewUsers1.TabIndex = 5;
            // 
            // form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 521);
            Controls.Add(viewUsers1);
            Controls.Add(activateAccount1);
            Controls.Add(signUp1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Load += EmpFunc_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button7;
        private Label branchID;
        private Label Name;
        private Label userName;
        private Panel panel3;
        private Button button8;
        private Label label1;
        private Button button9;
        private SignUp signUp1;
        private ActivateAccount activateAccount1;
        private ViewUsers viewUsers1;
    }
}