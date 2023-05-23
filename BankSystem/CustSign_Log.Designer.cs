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
            button2 = new Button();
            bar1 = new bar();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(364, 145);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // signUp1
            // 
            signUp1.BackColor = Color.Transparent;
            signUp1.branchID = null;
            signUp1.Location = new Point(12, 39);
            signUp1.Name = "signUp1";
            signUp1.Size = new Size(405, 489);
            signUp1.TabIndex = 4;
            signUp1.Load += signUp1_Load_2;
            // 
            // logIn2
            // 
            logIn2.BackColor = Color.Transparent;
            logIn2.Customer = null;
            logIn2.Employee = null;
            logIn2.Location = new Point(525, 54);
            logIn2.Margin = new Padding(3, 4, 3, 4);
            logIn2.Name = "logIn2";
            logIn2.Size = new Size(470, 484);
            logIn2.state = 0;
            logIn2.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(547, 335);
            button2.Name = "button2";
            button2.Size = new Size(246, 34);
            button2.TabIndex = 34;
            button2.Text = "sign up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // bar1
            // 
            bar1.Location = new Point(-2, -2);
            bar1.Name = "bar1";
            bar1.Size = new Size(949, 35);
            bar1.TabIndex = 35;
            // 
            // CustSign_Log
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(898, 585);
            Controls.Add(bar1);
            Controls.Add(button2);
            Controls.Add(logIn2);
            Controls.Add(signUp1);
            Controls.Add(button1);
            Name = "CustSign_Log";
            Text = "Sign Up or Login";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion
        private LogIn logIn1;
        private Button button1;
        private SignUp signUp1;
        private LogIn logIn2;
        private Button button2;
        private bar bar1;
    }
}