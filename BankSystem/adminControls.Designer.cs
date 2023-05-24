namespace BankSystem
{
    partial class adminControls
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(58, 38);
            button1.Name = "button1";
            button1.Size = new Size(180, 61);
            button1.TabIndex = 0;
            button1.Text = "Add Bank";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(58, 128);
            button2.Name = "button2";
            button2.Size = new Size(180, 65);
            button2.TabIndex = 1;
            button2.Text = "Add Branch";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(58, 227);
            button3.Name = "button3";
            button3.Size = new Size(180, 59);
            button3.TabIndex = 2;
            button3.Text = "View Report";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // adminControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "adminControls";
            Size = new Size(307, 325);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}
