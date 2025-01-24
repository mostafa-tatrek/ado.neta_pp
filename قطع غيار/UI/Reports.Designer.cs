namespace UI
{
    partial class Reports
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
            ReportGrid = new DataGridView();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)ReportGrid).BeginInit();
            SuspendLayout();
            // 
            // ReportGrid
            // 
            ReportGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReportGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportGrid.Location = new Point(32, 42);
            ReportGrid.Name = "ReportGrid";
            ReportGrid.RowHeadersWidth = 51;
            ReportGrid.Size = new Size(1080, 496);
            ReportGrid.TabIndex = 0;
            ReportGrid.CellContentClick += ReportGrid_CellContentClick;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Location = new Point(32, 5);
            button6.Name = "button6";
            button6.Size = new Size(43, 31);
            button6.TabIndex = 48;
            button6.Text = "<";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 553);
            Controls.Add(button6);
            Controls.Add(ReportGrid);
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            Load += Reports_Load;
            ((System.ComponentModel.ISupportInitialize)ReportGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ReportGrid;
        private Button button6;
    }
}