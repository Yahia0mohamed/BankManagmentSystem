namespace BankSystem
{
    partial class addBank
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
            bankID_txtBX = new TextBox();
            label8 = new Label();
            label7 = new Label();
            Address_txtBX = new TextBox();
            branchNum_txtBX = new TextBox();
            label6 = new Label();
            name_txtBX = new TextBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // bankID_txtBX
            // 
            bankID_txtBX.Location = new Point(176, 145);
            bankID_txtBX.Name = "bankID_txtBX";
            bankID_txtBX.Size = new Size(125, 27);
            bankID_txtBX.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(21, 151);
            label8.Name = "label8";
            label8.Size = new Size(77, 21);
            label8.TabIndex = 24;
            label8.Text = "Bank ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(21, 100);
            label7.Name = "label7";
            label7.Size = new Size(131, 21);
            label7.TabIndex = 23;
            label7.Text = "Bank Address";
            // 
            // Address_txtBX
            // 
            Address_txtBX.Location = new Point(176, 94);
            Address_txtBX.Name = "Address_txtBX";
            Address_txtBX.Size = new Size(125, 27);
            Address_txtBX.TabIndex = 22;
            // 
            // branchNum_txtBX
            // 
            branchNum_txtBX.Location = new Point(176, 46);
            branchNum_txtBX.Name = "branchNum_txtBX";
            branchNum_txtBX.Size = new Size(125, 27);
            branchNum_txtBX.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(23, 41);
            label6.Name = "label6";
            label6.Size = new Size(145, 21);
            label6.TabIndex = 20;
            label6.Text = "Branch number";
            // 
            // name_txtBX
            // 
            name_txtBX.Location = new Point(176, 197);
            name_txtBX.Name = "name_txtBX";
            name_txtBX.Size = new Size(125, 27);
            name_txtBX.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(21, 203);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 26;
            label1.Text = "Bank Name";
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(176, 257);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 28;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // addBank
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button2);
            Controls.Add(name_txtBX);
            Controls.Add(label1);
            Controls.Add(bankID_txtBX);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Address_txtBX);
            Controls.Add(branchNum_txtBX);
            Controls.Add(label6);
            Name = "addBank";
            Size = new Size(325, 310);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bankID_txtBX;
        private Label label8;
        private Label label7;
        private TextBox Address_txtBX;
        private TextBox branchNum_txtBX;
        private Label label6;
        private TextBox name_txtBX;
        private Label label1;
        private Button button2;
    }
}
