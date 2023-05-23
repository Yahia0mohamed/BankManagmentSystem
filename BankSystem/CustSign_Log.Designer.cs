namespace BankSystem
{
    partial class CustSign_Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustSign_Log));
            button1 = new Button();
            signUp1 = new SignUp();
            logIn2 = new LogIn();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(289, 439);
            button1.Name = "button1";
            button1.Size = new Size(279, 29);
            button1.TabIndex = 0;
            button1.Text = "sign up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // signUp1
            // 
            signUp1.BackColor = Color.Transparent;
            signUp1.Location = new Point(234, 95);
            signUp1.Name = "signUp1";
            signUp1.Size = new Size(394, 405);
            signUp1.TabIndex = 2;
            signUp1.Load += signUp1_Load;
            // 
            // logIn2
            // 
            logIn2.BackColor = Color.Transparent;
            logIn2.Customer = null;
            logIn2.Employee = null;
            logIn2.Location = new Point(247, 160);
            logIn2.Margin = new Padding(3, 4, 3, 4);
            logIn2.Name = "logIn2";
            logIn2.Size = new Size(297, 272);
            logIn2.state = 0;
            logIn2.TabIndex = 3;
            // 
            // CustSign_Log
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(898, 585);
            Controls.Add(signUp1);
            Controls.Add(logIn2);
            Controls.Add(button1);
            Name = "CustSign_Log";
            Text = "Sign Up or Login";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private SignUp signUp1;
        private LogIn logIn1;
        private LogIn logIn2;
    }
}