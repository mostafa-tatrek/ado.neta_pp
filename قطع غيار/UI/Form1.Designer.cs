﻿namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 303);
            button1.Name = "button1";
            button1.Size = new Size(190, 73);
            button1.TabIndex = 0;
            button1.Text = "الموردين";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(12, 403);
            button2.Name = "button2";
            button2.Size = new Size(190, 73);
            button2.TabIndex = 1;
            button2.Text = "العملاء";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(12, 204);
            button3.Name = "button3";
            button3.Size = new Size(190, 73);
            button3.TabIndex = 2;
            button3.Text = "التقارير";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(12, 495);
            button4.Name = "button4";
            button4.Size = new Size(190, 73);
            button4.TabIndex = 5;
            button4.Text = "الخروج";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Teal;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(12, 107);
            button5.Name = "button5";
            button5.Size = new Size(190, 73);
            button5.TabIndex = 4;
            button5.Text = "الفواتير";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Teal;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(12, 12);
            button6.Name = "button6";
            button6.Size = new Size(190, 73);
            button6.TabIndex = 3;
            button6.Text = "القطع";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2025_01_23_at_18_07_19_99224e74;
            pictureBox1.Location = new Point(208, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1223, 664);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(410, -3);
            label1.Name = "label1";
            label1.Size = new Size(548, 54);
            label1.TabIndex = 7;
            label1.Text = "مرحبا بكم في معرض قطع الغيار";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1179, 580);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
