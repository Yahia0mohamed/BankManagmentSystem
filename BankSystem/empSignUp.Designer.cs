﻿namespace BankSystem
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
            label7 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(45, 74);
            label2.Name = "label2";
            label2.Size = new Size(69, 26);
            label2.TabIndex = 21;
            label2.Text = "Name";
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
            branchID.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            branchID.ForeColor = SystemColors.ControlLightLight;
            branchID.Location = new Point(40, 127);
            branchID.Name = "branchID";
            branchID.Size = new Size(103, 26);
            branchID.TabIndex = 23;
            branchID.Text = "BranchID";
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
            button1.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(181, 279);
            button1.Name = "button1";
            button1.Size = new Size(94, 28);
            button1.TabIndex = 31;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(40, 229);
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
            label6.Location = new Point(40, 176);
            label6.Name = "label6";
            label6.Size = new Size(121, 26);
            label6.TabIndex = 29;
            label6.Text = "User Name";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(48, -9);
            label7.Name = "label7";
            label7.Size = new Size(227, 67);
            label7.TabIndex = 32;
            label7.Text = "Sign Up";
            // 
            // empSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label7);
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
        private Label label7;
    }
}
