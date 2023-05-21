namespace BankSystem
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            button2 = new Button();
            SSN_txtBX = new TextBox();
            name_txtBX = new TextBox();
            address_txtBX = new TextBox();
            phone_txtBX = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pass_txtBX = new TextBox();
            user_txtBX = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 28);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "sign up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(543, 28);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "login";
            button2.UseVisualStyleBackColor = true;
            // 
            // SSN_txtBX
            // 
            SSN_txtBX.Location = new Point(123, 82);
            SSN_txtBX.Name = "SSN_txtBX";
            SSN_txtBX.Size = new Size(125, 27);
            SSN_txtBX.TabIndex = 2;
            // 
            // name_txtBX
            // 
            name_txtBX.Location = new Point(123, 134);
            name_txtBX.Name = "name_txtBX";
            name_txtBX.Size = new Size(125, 27);
            name_txtBX.TabIndex = 3;
            // 
            // address_txtBX
            // 
            address_txtBX.Location = new Point(123, 191);
            address_txtBX.Name = "address_txtBX";
            address_txtBX.Size = new Size(125, 27);
            address_txtBX.TabIndex = 4;
            // 
            // phone_txtBX
            // 
            phone_txtBX.Location = new Point(123, 249);
            phone_txtBX.Name = "phone_txtBX";
            phone_txtBX.Size = new Size(125, 27);
            phone_txtBX.TabIndex = 5;
            phone_txtBX.Text = "(+20)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(29, 82);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 6;
            label1.Text = "SSN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(29, 134);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(29, 191);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 8;
            label3.Text = "address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(29, 249);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 9;
            label4.Text = "phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(29, 367);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 13;
            label5.Text = "password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(29, 318);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 12;
            label6.Text = "user name";
            // 
            // pass_txtBX
            // 
            pass_txtBX.Location = new Point(123, 367);
            pass_txtBX.Name = "pass_txtBX";
            pass_txtBX.Size = new Size(125, 27);
            pass_txtBX.TabIndex = 11;
            // 
            // user_txtBX
            // 
            user_txtBX.Location = new Point(123, 315);
            user_txtBX.Name = "user_txtBX";
            user_txtBX.Size = new Size(125, 27);
            user_txtBX.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
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
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Sign Up or Login";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox SSN_txtBX;
        private TextBox name_txtBX;
        private TextBox address_txtBX;
        private TextBox phone_txtBX;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox pass_txtBX;
        private TextBox user_txtBX;
    }
}