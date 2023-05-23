namespace BankSystem
{
    partial class empSignUp
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
            label2 = new Label();
            name_txtBX = new TextBox();
            branchID = new Label();
            branchID_txtBX = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            pass_txtBX = new TextBox();
            user_txtBX = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(73, 74);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 21;
            label2.Text = "name";
            // 
            // name_txtBX
            // 
            name_txtBX.Location = new Point(167, 74);
            name_txtBX.Name = "name_txtBX";
            name_txtBX.Size = new Size(125, 27);
            name_txtBX.TabIndex = 20;
            // 
            // branchID
            // 
            branchID.AutoSize = true;
            branchID.BackColor = Color.Transparent;
            branchID.ForeColor = SystemColors.ControlLightLight;
            branchID.Location = new Point(73, 126);
            branchID.Name = "branchID";
            branchID.Size = new Size(69, 20);
            branchID.TabIndex = 23;
            branchID.Text = "branchID";
            // 
            // branchID_txtBX
            // 
            branchID_txtBX.Location = new Point(167, 126);
            branchID_txtBX.Name = "branchID_txtBX";
            branchID_txtBX.Size = new Size(125, 27);
            branchID_txtBX.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(181, 276);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 31;
            button1.Text = "confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(73, 229);
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
            label6.Location = new Point(73, 180);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 29;
            label6.Text = "user name";
            // 
            // pass_txtBX
            // 
            pass_txtBX.Location = new Point(167, 229);
            pass_txtBX.Name = "pass_txtBX";
            pass_txtBX.Size = new Size(125, 27);
            pass_txtBX.TabIndex = 28;
            // 
            // user_txtBX
            // 
            user_txtBX.Location = new Point(167, 177);
            user_txtBX.Name = "user_txtBX";
            user_txtBX.Size = new Size(125, 27);
            user_txtBX.TabIndex = 27;
            // 
            // empSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(pass_txtBX);
            Controls.Add(user_txtBX);
            Controls.Add(branchID);
            Controls.Add(branchID_txtBX);
            Controls.Add(label2);
            Controls.Add(name_txtBX);
            Name = "empSignUp";
            Size = new Size(406, 349);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox name_txtBX;
        private Label branchID;
        private TextBox branchID_txtBX;
        private Button button1;
        private Label label5;
        private Label label6;
        private TextBox pass_txtBX;
        private TextBox user_txtBX;
    }
}
