namespace BankSystem
{
    partial class AccRejLoan
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            id_txtBX = new TextBox();
            button6 = new Button();
            button5 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(165, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 19;
            label2.Text = "waiting list";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 238);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 17;
            label1.Text = "select loan ID";
            label1.Click += label1_Click;
            // 
            // id_txtBX
            // 
            id_txtBX.Location = new Point(221, 231);
            id_txtBX.Name = "id_txtBX";
            id_txtBX.Size = new Size(125, 27);
            id_txtBX.TabIndex = 16;
            id_txtBX.TextChanged += id_txtBX_TextChanged;
            // 
            // button6
            // 
            button6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(295, 291);
            button6.Name = "button6";
            button6.Size = new Size(109, 39);
            button6.TabIndex = 15;
            button6.Text = "Reject Loan";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(13, 291);
            button5.Name = "button5";
            button5.Size = new Size(109, 39);
            button5.TabIndex = 14;
            button5.Text = "Accept Loan";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(155, 366);
            button1.Name = "button1";
            button1.Size = new Size(109, 39);
            button1.TabIndex = 20;
            button1.Text = "load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AccRejLoan
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
            Controls.Add(button5);
            Name = "AccRejLoan";
            Size = new Size(440, 408);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox id_txtBX;
        private Button button6;
        private Button button5;
        private Button button1;
    }
}
