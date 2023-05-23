namespace BankSystem
{
    partial class CustFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustFunc));
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            stateLBL = new Label();
            lbl = new Label();
            RequestLoan = new Button();
            panel2 = new Panel();
            ShowLoanTypes = new Button();
            loanRequest1 = new loanRequest();
            loanTypes1 = new loanTypes();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(stateLBL);
            panel1.Controls.Add(lbl);
            panel1.Location = new Point(12, 3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(946, 79);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(381, 12);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(194, 39);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(194, 12);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 39);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 12);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // stateLBL
            // 
            stateLBL.AutoSize = true;
            stateLBL.BackColor = Color.Transparent;
            stateLBL.ForeColor = Color.White;
            stateLBL.Location = new Point(829, 39);
            stateLBL.Name = "stateLBL";
            stateLBL.Size = new Size(50, 20);
            stateLBL.TabIndex = 1;
            stateLBL.Text = "label1";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(805, 12);
            lbl.Name = "lbl";
            lbl.Size = new Size(85, 20);
            lbl.TabIndex = 0;
            lbl.Text = "my account";
            // 
            // RequestLoan
            // 
            RequestLoan.BackColor = Color.Transparent;
            RequestLoan.Location = new Point(24, 366);
            RequestLoan.Margin = new Padding(3, 4, 3, 4);
            RequestLoan.Name = "RequestLoan";
            RequestLoan.Size = new Size(106, 61);
            RequestLoan.TabIndex = 1;
            RequestLoan.Text = "request Loan";
            RequestLoan.UseVisualStyleBackColor = false;
            RequestLoan.Click += RequestLoan_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(ShowLoanTypes);
            panel2.Controls.Add(RequestLoan);
            panel2.Location = new Point(12, 90);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(168, 536);
            panel2.TabIndex = 4;
            // 
            // ShowLoanTypes
            // 
            ShowLoanTypes.BackColor = Color.Transparent;
            ShowLoanTypes.Location = new Point(24, 100);
            ShowLoanTypes.Margin = new Padding(3, 4, 3, 4);
            ShowLoanTypes.Name = "ShowLoanTypes";
            ShowLoanTypes.Size = new Size(106, 61);
            ShowLoanTypes.TabIndex = 2;
            ShowLoanTypes.Text = "loan types";
            ShowLoanTypes.UseVisualStyleBackColor = false;
            ShowLoanTypes.Click += ShowLoanTypes_Click;
            // 
            // loanRequest1
            // 
            loanRequest1.BackColor = Color.Transparent;
            loanRequest1.Location = new Point(333, 190);
            loanRequest1.Name = "loanRequest1";
            loanRequest1.Size = new Size(339, 327);
            loanRequest1.TabIndex = 5;
            loanRequest1.Load += loanRequest1_Load;
            // 
            // loanTypes1
            // 
            loanTypes1.BackColor = Color.Transparent;
            loanTypes1.Location = new Point(333, 190);
            loanTypes1.Margin = new Padding(3, 4, 3, 4);
            loanTypes1.Name = "loanTypes1";
            loanTypes1.Size = new Size(382, 349);
            loanTypes1.TabIndex = 6;
            // 
            // CustFunc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(970, 649);
            Controls.Add(loanTypes1);
            Controls.Add(loanRequest1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "CustFunc";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label stateLBL;
        private Label lbl;
        private Button RequestLoan;
        private Panel panel2;
        private Button ShowLoanTypes;
        private loanRequest loanRequest1;
        private loanTypes loanTypes1;
    }
}