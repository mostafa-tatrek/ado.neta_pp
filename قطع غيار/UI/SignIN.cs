using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SignIN : Form
    {
        public SignIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)
                || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("All fields must be filled");
            }
            else
            {
                if(textBox1.Text == "admin@gmail.com" && textBox2.Text == "admin123")
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
            }
        }
    }
}
