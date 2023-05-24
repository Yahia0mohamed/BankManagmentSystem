namespace BankSystem
{
    partial class AdminFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFunc));
            code_txtbx = new TextBox();
            label1 = new Label();
            button4 = new Button();
            adminControls1 = new adminControls();
            addBank1 = new addBank();
            addBranch1 = new addBranch();
            SuspendLayout();
            // 
            // code_txtbx
            // 
            code_txtbx.Location = new Point(482, 164);
            code_txtbx.Name = "code_txtbx";
            code_txtbx.Size = new Size(291, 27);
            code_txtbx.TabIndex = 4;
            code_txtbx.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(482, 119);
            label1.Name = "label1";
            label1.Size = new Size(230, 27);
            label1.TabIndex = 5;
            label1.Text = "Enter Access Code:";
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(482, 213);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "Confirm";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // adminControls1
            // 
            adminControls1.addBranch = null;
            adminControls1.BackColor = Color.Transparent;
            adminControls1.instance = null;
            adminControls1.Location = new Point(460, 60);
            adminControls1.Name = "adminControls1";
            adminControls1.Size = new Size(384, 406);
            adminControls1.TabIndex = 7;
            adminControls1.Load += adminControls1_Load;
            // 
            // addBank1
            // 
            addBank1.BackColor = Color.Transparent;
            addBank1.Location = new Point(50, 50);
            addBank1.Name = "addBank1";
            addBank1.Size = new Size(406, 388);
            addBank1.TabIndex = 8;
            // 
            // addBranch1
            // 
            addBranch1.BackColor = Color.Transparent;
            addBranch1.Location = new Point(50, 76);
            addBranch1.Name = "addBranch1";
            addBranch1.Size = new Size(404, 325);
            addBranch1.TabIndex = 9;
            // 
            // AdminFunc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(addBranch1);
            Controls.Add(addBank1);
            Controls.Add(adminControls1);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(code_txtbx);
            Name = "AdminFunc";
            Text = "AdminFunc";
            Load += AdminFunc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox code_txtbx;
        private Label label1;
        private Button button4;
        private adminControls adminControls1;
        private addBank addBank1;
        private addBranch addBranch1;
    }
}