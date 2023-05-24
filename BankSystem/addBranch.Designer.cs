namespace BankSystem
{
    partial class addBranch
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
            branchID_txtBX = new TextBox();
            label6 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // bankID_txtBX
            // 
            bankID_txtBX.Location = new Point(175, 131);
            bankID_txtBX.Name = "bankID_txtBX";
            bankID_txtBX.Size = new Size(125, 27);
            bankID_txtBX.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(20, 137);
            label8.Name = "label8";
            label8.Size = new Size(77, 21);
            label8.TabIndex = 18;
            label8.Text = "Bank ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(20, 86);
            label7.Name = "label7";
            label7.Size = new Size(149, 21);
            label7.TabIndex = 17;
            label7.Text = "Branch Address";
            // 
            // Address_txtBX
            // 
            Address_txtBX.Location = new Point(175, 80);
            Address_txtBX.Name = "Address_txtBX";
            Address_txtBX.Size = new Size(125, 27);
            Address_txtBX.TabIndex = 16;
            // 
            // branchID_txtBX
            // 
            branchID_txtBX.Location = new Point(175, 32);
            branchID_txtBX.Name = "branchID_txtBX";
            branchID_txtBX.Size = new Size(125, 27);
            branchID_txtBX.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(22, 27);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 14;
            label6.Text = "Branch ID";
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(175, 205);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 27;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // addBrach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button2);
            Controls.Add(bankID_txtBX);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Address_txtBX);
            Controls.Add(branchID_txtBX);
            Controls.Add(label6);
            Name = "addBrach";
            Size = new Size(323, 260);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bankID_txtBX;
        private Label label8;
        private Label label7;
        private TextBox Address_txtBX;
        private TextBox branchID_txtBX;
        private Label label6;
        private Button button2;
    }
}
