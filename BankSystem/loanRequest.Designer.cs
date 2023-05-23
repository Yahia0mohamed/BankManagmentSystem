namespace BankSystem
{
    partial class loanRequest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BID_txtBX = new TextBox();
            LType_txtBX = new TextBox();
            SSN_txtBX = new TextBox();
            label4 = new Label();
            amount_txtBX = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(35, 173);
            label3.Name = "label3";
            label3.Size = new Size(109, 26);
            label3.TabIndex = 26;
            label3.Text = "Branch ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(30, 116);
            label2.Name = "label2";
            label2.Size = new Size(114, 26);
            label2.TabIndex = 25;
            label2.Text = "Loan Type";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(35, 57);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 24;
            label1.Text = "SSN";
            // 
            // BID_txtBX
            // 
            BID_txtBX.Location = new Point(155, 174);
            BID_txtBX.Name = "BID_txtBX";
            BID_txtBX.Size = new Size(125, 27);
            BID_txtBX.TabIndex = 23;
            // 
            // LType_txtBX
            // 
            LType_txtBX.Location = new Point(155, 117);
            LType_txtBX.Name = "LType_txtBX";
            LType_txtBX.Size = new Size(125, 27);
            LType_txtBX.TabIndex = 22;
            // 
            // SSN_txtBX
            // 
            SSN_txtBX.Location = new Point(155, 57);
            SSN_txtBX.Name = "SSN_txtBX";
            SSN_txtBX.Size = new Size(125, 27);
            SSN_txtBX.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(35, 226);
            label4.Name = "label4";
            label4.Size = new Size(88, 26);
            label4.TabIndex = 28;
            label4.Text = "Amount";
            // 
            // amount_txtBX
            // 
            amount_txtBX.Location = new Point(155, 227);
            amount_txtBX.Name = "amount_txtBX";
            amount_txtBX.Size = new Size(125, 27);
            amount_txtBX.TabIndex = 27;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(169, 273);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 29;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // loanRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(amount_txtBX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BID_txtBX);
            Controls.Add(LType_txtBX);
            Controls.Add(SSN_txtBX);
            Name = "loanRequest";
            Size = new Size(377, 341);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox BID_txtBX;
        private TextBox LType_txtBX;
        private TextBox SSN_txtBX;
        private Label label4;
        private TextBox amount_txtBX;
        private Button button1;
    }
}
