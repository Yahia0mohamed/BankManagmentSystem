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
            lbl = new Label();
            stateLBL = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            RequestLoan = new Button();
            panel2 = new Panel();
            loanTypes1 = new loanTypes();
            ShowLoanTypes = new Button();
            loanRequest1 = new loanRequest();
            bar1 = new bar();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lbl);
            panel1.Controls.Add(stateLBL);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(482, 42);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 76);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(399, 3);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(52, 11);
            lbl.Name = "lbl";
            lbl.Size = new Size(112, 21);
            lbl.TabIndex = 0;
            lbl.Text = "My Account";
            // 
            // stateLBL
            // 
            stateLBL.AutoSize = true;
            stateLBL.BackColor = Color.Transparent;
            stateLBL.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            stateLBL.ForeColor = Color.White;
            stateLBL.Location = new Point(76, 36);
            stateLBL.Name = "stateLBL";
            stateLBL.Size = new Size(50, 18);
            stateLBL.TabIndex = 1;
            stateLBL.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(293, 33);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(13, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(33, 34);
            panel3.TabIndex = 7;
            panel3.Paint += panel3_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(293, 3);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 4;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(183, 3);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(183, 33);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // RequestLoan
            // 
            RequestLoan.BackColor = Color.Transparent;
            RequestLoan.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            RequestLoan.Location = new Point(118, 203);
            RequestLoan.Margin = new Padding(3, 4, 3, 4);
            RequestLoan.Name = "RequestLoan";
            RequestLoan.Size = new Size(201, 61);
            RequestLoan.TabIndex = 1;
            RequestLoan.Text = "Request Loan";
            RequestLoan.UseVisualStyleBackColor = false;
            RequestLoan.Click += RequestLoan_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(loanTypes1);
            panel2.Controls.Add(ShowLoanTypes);
            panel2.Controls.Add(loanRequest1);
            panel2.Controls.Add(RequestLoan);
            panel2.Location = new Point(482, 126);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 510);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // loanTypes1
            // 
            loanTypes1.BackColor = Color.Transparent;
            loanTypes1.Location = new Point(24, 23);
            loanTypes1.Margin = new Padding(3, 4, 3, 4);
            loanTypes1.Name = "loanTypes1";
            loanTypes1.Size = new Size(396, 349);
            loanTypes1.TabIndex = 6;
            loanTypes1.Load += loanTypes1_Load;
            // 
            // ShowLoanTypes
            // 
            ShowLoanTypes.BackColor = Color.Transparent;
            ShowLoanTypes.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ShowLoanTypes.Location = new Point(118, 63);
            ShowLoanTypes.Margin = new Padding(3, 4, 3, 4);
            ShowLoanTypes.Name = "ShowLoanTypes";
            ShowLoanTypes.Size = new Size(201, 61);
            ShowLoanTypes.TabIndex = 2;
            ShowLoanTypes.Text = "Loan Types";
            ShowLoanTypes.UseVisualStyleBackColor = false;
            ShowLoanTypes.Click += ShowLoanTypes_Click;
            // 
            // loanRequest1
            // 
            loanRequest1.BackColor = Color.Transparent;
            loanRequest1.Location = new Point(42, 23);
            loanRequest1.Name = "loanRequest1";
            loanRequest1.Size = new Size(339, 327);
            loanRequest1.TabIndex = 5;
            loanRequest1.Load += loanRequest1_Load;
            // 
            // bar1
            // 
            bar1.Location = new Point(0, 0);
            bar1.Name = "bar1";
            bar1.Size = new Size(981, 39);
            bar1.TabIndex = 8;
            bar1.Load += bar1_Load;
            // 
            // CustFunc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(970, 649);
            Controls.Add(bar1);
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
        private Panel panel3;
        private bar bar1;
    }
}