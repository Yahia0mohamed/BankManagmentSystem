namespace BankSystem
{
    partial class ActivateAccount
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
            SSN_txtBX = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            branch_txtBX = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // SSN_txtBX
            // 
            SSN_txtBX.AutoSize = true;
            SSN_txtBX.BackColor = Color.Transparent;
            SSN_txtBX.ForeColor = Color.White;
            SSN_txtBX.Location = new Point(28, 18);
            SSN_txtBX.Name = "SSN_txtBX";
            SSN_txtBX.Size = new Size(36, 20);
            SSN_txtBX.TabIndex = 0;
            SSN_txtBX.Text = "SSN";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 66);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "branch";
            // 
            // branch_txtBX
            // 
            branch_txtBX.Location = new Point(83, 63);
            branch_txtBX.Name = "branch_txtBX";
            branch_txtBX.Size = new Size(125, 27);
            branch_txtBX.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(83, 113);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 27;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // ActivateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button1);
            Controls.Add(branch_txtBX);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(SSN_txtBX);
            Name = "ActivateAccount";
            Size = new Size(250, 166);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SSN_txtBX;
        private TextBox textBox1;
        private Label label1;
        private TextBox branch_txtBX;
        private Button button1;
    }
}
