namespace UI
{
    partial class InsertParts
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
            button5 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            PPrice = new TextBox();
            PQuantity = new TextBox();
            PName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            PArtsGrid = new DataGridView();
            label6 = new Label();
            CategoriesComb = new ComboBox();
            SuppliersComb = new ComboBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)PArtsGrid).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.Location = new Point(885, 495);
            button5.Name = "button5";
            button5.Size = new Size(154, 44);
            button5.TabIndex = 43;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(770, 37);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(270, 27);
            textBox5.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(713, 36);
            label5.Name = "label5";
            label5.Size = new Size(39, 28);
            label5.TabIndex = 41;
            label5.Text = " ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(662, 208);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 39;
            label1.Text = "Suppliers";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(722, 495);
            button4.Name = "button4";
            button4.Size = new Size(157, 44);
            button4.TabIndex = 38;
            button4.Text = "Sync Data";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(722, 424);
            button3.Name = "button3";
            button3.Size = new Size(317, 44);
            button3.TabIndex = 37;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(722, 361);
            button2.Name = "button2";
            button2.Size = new Size(317, 44);
            button2.TabIndex = 36;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(722, 298);
            button1.Name = "button1";
            button1.Size = new Size(317, 44);
            button1.TabIndex = 35;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // PPrice
            // 
            PPrice.Location = new Point(770, 119);
            PPrice.Name = "PPrice";
            PPrice.Size = new Size(270, 27);
            PPrice.TabIndex = 34;
            // 
            // PQuantity
            // 
            PQuantity.Location = new Point(770, 161);
            PQuantity.Name = "PQuantity";
            PQuantity.Size = new Size(270, 27);
            PQuantity.TabIndex = 33;
            // 
            // PName
            // 
            PName.Location = new Point(770, 77);
            PName.Name = "PName";
            PName.Size = new Size(270, 27);
            PName.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(693, 118);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 31;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(662, 157);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 30;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(689, 73);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 29;
            label2.Text = "Name";
            // 
            // PArtsGrid
            // 
            PArtsGrid.AllowUserToResizeColumns = false;
            PArtsGrid.AllowUserToResizeRows = false;
            PArtsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PArtsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PArtsGrid.Location = new Point(3, 37);
            PArtsGrid.Name = "PArtsGrid";
            PArtsGrid.RowHeadersWidth = 51;
            PArtsGrid.Size = new Size(643, 499);
            PArtsGrid.TabIndex = 28;
            PArtsGrid.CellContentClick += PArtsGrid_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(653, 253);
            label6.Name = "label6";
            label6.Size = new Size(112, 28);
            label6.TabIndex = 44;
            label6.Text = "Categories";
            // 
            // CategoriesComb
            // 
            CategoriesComb.FormattingEnabled = true;
            CategoriesComb.Location = new Point(771, 253);
            CategoriesComb.Name = "CategoriesComb";
            CategoriesComb.Size = new Size(268, 28);
            CategoriesComb.TabIndex = 45;
            // 
            // SuppliersComb
            // 
            SuppliersComb.FormattingEnabled = true;
            SuppliersComb.Location = new Point(772, 208);
            SuppliersComb.Name = "SuppliersComb";
            SuppliersComb.Size = new Size(268, 28);
            SuppliersComb.TabIndex = 46;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Location = new Point(3, 0);
            button6.Name = "button6";
            button6.Size = new Size(43, 31);
            button6.TabIndex = 47;
            button6.Text = "<";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // InsertParts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1068, 553);
            Controls.Add(button6);
            Controls.Add(SuppliersComb);
            Controls.Add(CategoriesComb);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PPrice);
            Controls.Add(PQuantity);
            Controls.Add(PName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PArtsGrid);
            Name = "InsertParts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InsertParts";
            Load += InsertParts_Load;
            ((System.ComponentModel.ISupportInitialize)PArtsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private TextBox textBox5;
        private Label label5;
        private TextBox CAddress;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox PPrice;
        private TextBox PQuantity;
        private TextBox PName;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView PArtsGrid;
        private Label label6;
        private ComboBox CategoriesComb;
        private ComboBox SuppliersComb;
        private Button button6;
    }
}