namespace BankSystem
{
    partial class LogIn
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
            confirmBtn = new Button();
            label5 = new Label();
            label6 = new Label();
            pass_txtBX = new TextBox();
            user_txtBX = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // confirmBtn
            // 
            confirmBtn.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            confirmBtn.Location = new Point(165, 228);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(94, 24);
            confirmBtn.TabIndex = 31;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(30, 182);
            label5.Name = "label5";
            label5.Size = new Size(108, 26);
            label5.TabIndex = 30;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(30, 129);
            label6.Name = "label6";
            label6.Size = new Size(121, 26);
            label6.TabIndex = 29;
            label6.Text = "User Name";
            // 
            // pass_txtBX
            // 
            pass_txtBX.Location = new Point(151, 181);
            pass_txtBX.Name = "pass_txtBX";
            pass_txtBX.Size = new Size(125, 27);
            pass_txtBX.TabIndex = 28;
            // 
            // user_txtBX
            // 
            user_txtBX.Location = new Point(151, 129);
            user_txtBX.Name = "user_txtBX";
            user_txtBX.Size = new Size(125, 27);
            user_txtBX.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(187, 67);
            label1.TabIndex = 32;
            label1.Text = "Log In";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label1);
            Controls.Add(confirmBtn);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(pass_txtBX);
            Controls.Add(user_txtBX);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LogIn";
            Size = new Size(376, 387);
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confirmBtn;
        private Label label5;
        private Label label6;
        private TextBox pass_txtBX;
        private TextBox user_txtBX;
        private Label label1;
    }
}
