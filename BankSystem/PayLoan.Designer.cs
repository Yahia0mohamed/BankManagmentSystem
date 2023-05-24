namespace BankSystem
{
    partial class PayLoan
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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            id_txtBX = new TextBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(47, 308);
            button1.Name = "button1";
            button1.Size = new Size(109, 39);
            button1.TabIndex = 27;
            button1.Text = "load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(224, 17);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 26;
            label2.Text = "loan list";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(103, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(124, 255);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 24;
            label1.Text = "select loan ID";
            // 
            // id_txtBX
            // 
            id_txtBX.Location = new Point(255, 248);
            id_txtBX.Name = "id_txtBX";
            id_txtBX.Size = new Size(125, 27);
            id_txtBX.TabIndex = 23;
            // 
            // button6
            // 
            button6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(329, 308);
            button6.Name = "button6";
            button6.Size = new Size(109, 39);
            button6.TabIndex = 22;
            button6.Text = "pay Loan";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // PayLoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(id_txtBX);
            Controls.Add(button6);
            Name = "PayLoan";
            Size = new Size(499, 398);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox id_txtBX;
        private Button button6;
    }
}
