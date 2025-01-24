namespace UI
{
    partial class Customers
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
            CPhone = new TextBox();
            CEmail = new TextBox();
            CName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            CustomersGrid = new DataGridView();
            CAddress = new TextBox();
            label1 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)CustomersGrid).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(653, 434);
            button4.Name = "button4";
            button4.Size = new Size(317, 44);
            button4.TabIndex = 22;
            button4.Text = "Sync Data";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(653, 366);
            button3.Name = "button3";
            button3.Size = new Size(317, 44);
            button3.TabIndex = 21;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(652, 297);
            button2.Name = "button2";
            button2.Size = new Size(317, 44);
            button2.TabIndex = 20;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(653, 227);
            button1.Name = "button1";
            button1.Size = new Size(317, 44);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CPhone
            // 
            CPhone.Location = new Point(745, 96);
            CPhone.Name = "CPhone";
            CPhone.Size = new Size(225, 27);
            CPhone.TabIndex = 18;
            // 
            // CEmail
            // 
            CEmail.Location = new Point(745, 138);
            CEmail.Name = "CEmail";
            CEmail.Size = new Size(225, 27);
            CEmail.TabIndex = 17;
            // 
            // CName
            // 
            CName.Location = new Point(745, 54);
            CName.Name = "CName";
            CName.Size = new Size(225, 27);
            CName.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(668, 95);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 15;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(675, 134);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 14;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(668, 50);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 13;
            label2.Text = "Name";
            // 
            // CustomersGrid
            // 
            CustomersGrid.AllowUserToResizeColumns = false;
            CustomersGrid.AllowUserToResizeRows = false;
            CustomersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersGrid.Location = new Point(12, 14);
            CustomersGrid.Name = "CustomersGrid";
            CustomersGrid.RowHeadersWidth = 51;
            CustomersGrid.Size = new Size(634, 525);
            CustomersGrid.TabIndex = 12;
            CustomersGrid.CellContentClick += CustomersGrid_CellContentClick_1;
            // 
            // CAddress
            // 
            CAddress.Location = new Point(745, 185);
            CAddress.Name = "CAddress";
            CAddress.Size = new Size(225, 27);
            CAddress.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(653, 181);
            label1.Name = "label1";
            label1.Size = new Size(87, 28);
            label1.TabIndex = 23;
            label1.Text = "Address";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(745, 14);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(225, 27);
            textBox5.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(697, 13);
            label5.Name = "label5";
            label5.Size = new Size(39, 28);
            label5.TabIndex = 25;
            label5.Text = " ID";
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.Location = new Point(653, 497);
            button5.Name = "button5";
            button5.Size = new Size(317, 44);
            button5.TabIndex = 27;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(button5);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(CAddress);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CPhone);
            Controls.Add(CEmail);
            Controls.Add(CName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CustomersGrid);
            Name = "Customers";
            Text = "Customers";
            Load += Customers_Load;
            ((System.ComponentModel.ISupportInitialize)CustomersGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox CPhone;
        private TextBox CEmail;
        private TextBox CName;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView CustomersGrid;
        private TextBox CAddress;
        private Label label1;
        private TextBox textBox5;
        private Label label5;
        private Button button5;
    }
}