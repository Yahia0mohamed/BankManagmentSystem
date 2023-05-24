namespace BankSystem
{
    partial class Loanoptions
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
            accRejLoan1 = new AccRejLoan();
            button2 = new Button();
            payLoan1 = new PayLoan();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(101, 244);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "waiting List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // accRejLoan1
            // 
            accRejLoan1.BackColor = Color.Transparent;
            accRejLoan1.Location = new Point(228, 66);
            accRejLoan1.Name = "accRejLoan1";
            accRejLoan1.Size = new Size(437, 378);
            accRejLoan1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(709, 244);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "loan List";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // payLoan1
            // 
            payLoan1.BackColor = Color.Transparent;
            payLoan1.Location = new Point(201, 66);
            payLoan1.Name = "payLoan1";
            payLoan1.Size = new Size(443, 407);
            payLoan1.TabIndex = 3;
            // 
            // Loanoptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_05_23_at_04_06_41;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(899, 492);
            Controls.Add(payLoan1);
            Controls.Add(button2);
            Controls.Add(accRejLoan1);
            Controls.Add(button1);
            Name = "Loanoptions";
            Text = "Loanoptions";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private AccRejLoan accRejLoan1;
        private Button button2;
        private PayLoan payLoan1;
    }
}