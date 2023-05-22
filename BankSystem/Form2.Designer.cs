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
            signUp1 = new SignUp();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(74, 188);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 0;
            button1.Text = "sign up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(551, 188);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 1;
            button2.Text = "login";
            button2.UseVisualStyleBackColor = true;
            // 
            // signUp1
            // 
            signUp1.BackColor = Color.Transparent;
            signUp1.Location = new Point(-23, 54);
            signUp1.Margin = new Padding(3, 2, 3, 2);
            signUp1.Name = "signUp1";
            signUp1.Size = new Size(271, 304);
            signUp1.TabIndex = 2;
            signUp1.Load += signUp1_Load;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(786, 439);
            Controls.Add(signUp1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Sign Up or Login";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private SignUp signUp1;
    }
}