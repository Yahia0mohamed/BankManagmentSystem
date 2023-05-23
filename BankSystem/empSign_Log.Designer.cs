namespace BankSystem
{
    partial class empSign_Log
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
            button1 = new Button();
            logIn1 = new LogIn();
            empSignUp1 = new empSignUp();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(297, 409);
            button1.Name = "button1";
            button1.Size = new Size(237, 29);
            button1.TabIndex = 0;
            button1.Text = "sign up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // logIn1
            // 
            logIn1.BackColor = Color.Transparent;
            logIn1.Customer = null;
            logIn1.Employee = null;
            logIn1.Location = new Point(240, 130);
            logIn1.Margin = new Padding(3, 4, 3, 4);
            logIn1.Name = "logIn1";
            logIn1.Size = new Size(314, 272);
            logIn1.state = 0;
            logIn1.TabIndex = 2;
            // 
            // empSignUp1
            // 
            empSignUp1.BackColor = Color.Transparent;
            empSignUp1.Location = new Point(228, 99);
            empSignUp1.Name = "empSignUp1";
            empSignUp1.Size = new Size(508, 436);
            empSignUp1.TabIndex = 3;
            empSignUp1.Load += empSignUp1_Load;
            // 
            // empSign_Log
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_05_21_at_04_22_36;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(869, 535);
            Controls.Add(empSignUp1);
            Controls.Add(logIn1);
            Controls.Add(button1);
            Name = "empSign_Log";
            Text = "empSign_Log";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private LogIn logIn1;
        private empSignUp empSignUp1;
    }
}