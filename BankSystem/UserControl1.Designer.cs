namespace BankSystem
{
    partial class SignUp
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
            label5 = new Label();
            label6 = new Label();
            pass_txtBX = new TextBox();
            user_txtBX = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            phone_txtBX = new TextBox();
            address_txtBX = new TextBox();
            name_txtBX = new TextBox();
            SSN_txtBX = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(69, 312);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 25;
            label5.Text = "password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(69, 263);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 24;
            label6.Text = "user name";
            // 
            // pass_txtBX
            // 
            pass_txtBX.Location = new Point(163, 312);
            pass_txtBX.Name = "pass_txtBX";
            pass_txtBX.Size = new Size(125, 27);
            pass_txtBX.TabIndex = 23;
            // 
            // user_txtBX
            // 
            user_txtBX.Location = new Point(163, 260);
            user_txtBX.Name = "user_txtBX";
            user_txtBX.Size = new Size(125, 27);
            user_txtBX.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(69, 194);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 21;
            label4.Text = "phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(69, 136);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 20;
            label3.Text = "address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(69, 79);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 19;
            label2.Text = "name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(69, 27);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 18;
            label1.Text = "SSN";
            // 
            // phone_txtBX
            // 
            phone_txtBX.Location = new Point(163, 194);
            phone_txtBX.Name = "phone_txtBX";
            phone_txtBX.Size = new Size(125, 27);
            phone_txtBX.TabIndex = 17;
            phone_txtBX.Text = "(+20)";
            // 
            // address_txtBX
            // 
            address_txtBX.Location = new Point(163, 136);
            address_txtBX.Name = "address_txtBX";
            address_txtBX.Size = new Size(125, 27);
            address_txtBX.TabIndex = 16;
            // 
            // name_txtBX
            // 
            name_txtBX.Location = new Point(163, 79);
            name_txtBX.Name = "name_txtBX";
            name_txtBX.Size = new Size(125, 27);
            name_txtBX.TabIndex = 15;
            // 
            // SSN_txtBX
            // 
            SSN_txtBX.Location = new Point(163, 27);
            SSN_txtBX.Name = "SSN_txtBX";
            SSN_txtBX.Size = new Size(125, 27);
            SSN_txtBX.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(177, 359);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 26;
            button1.Text = "confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(pass_txtBX);
            Controls.Add(user_txtBX);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(phone_txtBX);
            Controls.Add(address_txtBX);
            Controls.Add(name_txtBX);
            Controls.Add(SSN_txtBX);
            Name = "SignUp";
            Size = new Size(453, 391);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label6;
        private TextBox pass_txtBX;
        private TextBox user_txtBX;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox phone_txtBX;
        private TextBox address_txtBX;
        private TextBox name_txtBX;
        private TextBox SSN_txtBX;
        private Button button1;
    }
}
