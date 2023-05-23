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
            SuspendLayout();
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(165, 228);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(94, 29);
            confirmBtn.TabIndex = 31;
            confirmBtn.Text = "confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(56, 181);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 30;
            label5.Text = "password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(56, 132);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 29;
            label6.Text = "user name";
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
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
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
    }
}
