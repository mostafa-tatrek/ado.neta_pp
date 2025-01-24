namespace UI
{
    partial class Suppliers
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SPhone = new TextBox();
            SEmail = new TextBox();
            SName = new TextBox();
            SPhoneLAbel = new Label();
            label3 = new Label();
            label2 = new Label();
            SuppliersGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)SuppliersGrid).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.Location = new Point(653, 458);
            button5.Name = "button5";
            button5.Size = new Size(317, 44);
            button5.TabIndex = 43;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(745, 20);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(225, 27);
            textBox5.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(697, 19);
            label5.Name = "label5";
            label5.Size = new Size(39, 28);
            label5.TabIndex = 41;
            label5.Text = " ID";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(653, 395);
            button4.Name = "button4";
            button4.Size = new Size(317, 44);
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
            button3.Location = new Point(653, 327);
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
            button2.Location = new Point(652, 258);
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
            button1.Location = new Point(653, 188);
            button1.Name = "button1";
            button1.Size = new Size(317, 44);
            button1.TabIndex = 35;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SPhone
            // 
            SPhone.Location = new Point(745, 102);
            SPhone.Name = "SPhone";
            SPhone.Size = new Size(225, 27);
            SPhone.TabIndex = 34;
            SPhone.TextChanged += CPhone_TextChanged;
            // 
            // SEmail
            // 
            SEmail.Location = new Point(745, 144);
            SEmail.Name = "SEmail";
            SEmail.Size = new Size(225, 27);
            SEmail.TabIndex = 33;
            // 
            // SName
            // 
            SName.Location = new Point(745, 60);
            SName.Name = "SName";
            SName.Size = new Size(225, 27);
            SName.TabIndex = 32;
            // 
            // SPhoneLAbel
            // 
            SPhoneLAbel.AutoSize = true;
            SPhoneLAbel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SPhoneLAbel.Location = new Point(668, 101);
            SPhoneLAbel.Name = "SPhoneLAbel";
            SPhoneLAbel.Size = new Size(71, 28);
            SPhoneLAbel.TabIndex = 31;
            SPhoneLAbel.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(675, 140);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 30;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(668, 56);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 29;
            label2.Text = "Name";
            // 
            // SuppliersGrid
            // 
            SuppliersGrid.AllowUserToResizeColumns = false;
            SuppliersGrid.AllowUserToResizeRows = false;
            SuppliersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SuppliersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SuppliersGrid.Location = new Point(12, 20);
            SuppliersGrid.Name = "SuppliersGrid";
            SuppliersGrid.RowHeadersWidth = 51;
            SuppliersGrid.Size = new Size(634, 525);
            SuppliersGrid.TabIndex = 28;
            SuppliersGrid.CellContentClick += SuppliersGrid_CellContentClick;
            // 
            // Suppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 567);
            Controls.Add(button5);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(SPhone);
            Controls.Add(SEmail);
            Controls.Add(SName);
            Controls.Add(SPhoneLAbel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SuppliersGrid);
            Name = "Suppliers";
            Text = "Suppliers";
            Load += Suppliers_Load;
            ((System.ComponentModel.ISupportInitialize)SuppliersGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private TextBox textBox5;
        private Label label5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox SPhone;
        private TextBox SEmail;
        private TextBox SName;
        private Label SPhoneLAbel;
        private Label label3;
        private Label label2;
        private DataGridView SuppliersGrid;
    }
}