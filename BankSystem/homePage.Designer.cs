namespace BankSystem
{
    partial class homePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePage));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(175, 39);
            label1.Name = "label1";
            label1.Size = new Size(540, 52);
            label1.TabIndex = 0;
            label1.Text = "Bank Managment System";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(659, 156);
            button1.Name = "button1";
            button1.Size = new Size(146, 56);
            button1.TabIndex = 1;
            button1.Text = "Customer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(659, 253);
            button2.Name = "button2";
            button2.Size = new Size(146, 56);
            button2.TabIndex = 2;
            button2.Text = "Employee";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(805, 607);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "if admin";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.DodgerBlue;
            linkLabel1.Location = new Point(867, 607);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(38, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "click";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(649, 402);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(659, 350);
            button3.Name = "button3";
            button3.Size = new Size(146, 56);
            button3.TabIndex = 6;
            button3.Text = "Admin";
            button3.UseVisualStyleBackColor = true;
            // 
            // homePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(917, 660);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "homePage";
            Text = "Bank System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label3;
        private Button button3;
    }
}