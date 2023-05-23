namespace BankSystem
{
    partial class EmpFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpFunc));
            panel1 = new Panel();
            branchID = new Label();
            Name = new Label();
            userName = new Label();
            button1 = new Button();
            panel2 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(branchID);
            panel1.Controls.Add(Name);
            panel1.Controls.Add(userName);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 72);
            panel1.TabIndex = 0;
            // 
            // branchID
            // 
            branchID.AutoSize = true;
            branchID.ForeColor = Color.White;
            branchID.Location = new Point(267, 11);
            branchID.Name = "branchID";
            branchID.Size = new Size(50, 20);
            branchID.TabIndex = 5;
            branchID.Text = "label3";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.ForeColor = Color.White;
            Name.Location = new Point(138, 11);
            Name.Name = "Name";
            Name.Size = new Size(69, 20);
            Name.TabIndex = 4;
            Name.Text = "EmpFunc";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.ForeColor = Color.White;
            userName.Location = new Point(29, 11);
            userName.Name = "userName";
            userName.Size = new Size(50, 20);
            userName.TabIndex = 3;
            userName.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(591, 21);
            button1.Name = "button1";
            button1.Size = new Size(153, 29);
            button1.TabIndex = 2;
            button1.Text = "activate account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(12, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(129, 419);
            panel2.TabIndex = 1;
            // 
            // button7
            // 
            button7.Location = new Point(20, 333);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 8;
            button7.Text = "pay loan";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(20, 277);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 7;
            button6.Text = "reject loan";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(20, 218);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 6;
            button5.Text = "accept loan";
            button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(20, 14);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "add user";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(20, 72);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "view users";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(20, 137);
            button4.Name = "button4";
            button4.Size = new Size(94, 49);
            button4.TabIndex = 5;
            button4.Text = "view waiting list";
            button4.UseVisualStyleBackColor = true;
            // 
            // EmpFunc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 521);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
    }
}