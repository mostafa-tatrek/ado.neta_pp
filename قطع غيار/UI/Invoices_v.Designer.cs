namespace UI
{
    partial class Invoices_v
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            InvoicesGrid = new DataGridView();
            button5 = new Button();
            textBox1 = new TextBox();
            customComb = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)InvoicesGrid).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(571, 389);
            button4.Name = "button4";
            button4.Size = new Size(376, 44);
            button4.TabIndex = 22;
            button4.Text = "Sync Data";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Syncinvoices;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(571, 317);
            button3.Name = "button3";
            button3.Size = new Size(376, 44);
            button3.TabIndex = 21;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(571, 254);
            button2.Name = "button2";
            button2.Size = new Size(375, 44);
            button2.TabIndex = 20;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(571, 191);
            button1.Name = "button1";
            button1.Size = new Size(376, 44);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(699, 73);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(248, 27);
            textBox3.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(571, 69);
            label4.Name = "label4";
            label4.Size = new Size(122, 28);
            label4.TabIndex = 15;
            label4.Text = "Invoicedate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(570, 128);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 14;
            label3.Text = "CustomerID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(583, 13);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 13;
            label2.Text = "InvoicesID";
            // 
            // InvoicesGrid
            // 
            InvoicesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InvoicesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InvoicesGrid.Location = new Point(6, 13);
            InvoicesGrid.Name = "InvoicesGrid";
            InvoicesGrid.RowHeadersWidth = 51;
            InvoicesGrid.Size = new Size(540, 525);
            InvoicesGrid.TabIndex = 12;
            InvoicesGrid.CellContentClick += InvoicesGrid_CellContentClick_1;
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.Location = new Point(570, 459);
            button5.Name = "button5";
            button5.Size = new Size(377, 44);
            button5.TabIndex = 28;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(699, 13);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(248, 27);
            textBox1.TabIndex = 16;
            // 
            // customComb
            // 
            customComb.FormattingEnabled = true;
            customComb.Location = new Point(699, 128);
            customComb.Name = "customComb";
            customComb.Size = new Size(244, 28);
            customComb.TabIndex = 29;
            // 
            // Invoices_v
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(customComb);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(InvoicesGrid);
            Name = "Invoices_v";
            Text = "Invoices";
            Load += Invoices_v_Load;
            ((System.ComponentModel.ISupportInitialize)InvoicesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView InvoicesGrid;
        private Button button5;
        private TextBox textBox1;
        private ComboBox customComb;
    }
}