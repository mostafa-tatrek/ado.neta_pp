using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLAyer.Entities;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UI
{
    public partial class Invoices_v : Form
    {
        DataTable dt, dt2;
        Invoices invoice = new Invoices();
        public Invoices_v()
        {
            InitializeComponent();
        }
        private void Invoices_Load(object sender, EventArgs e)
        {

        }

        private void InvoicesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow selectedRow = InvoicesGrid.Rows[e.RowIndex];
                invoice.ID = Convert.ToInt32(selectedRow.Cells[0].Value);
                invoice.InvoiceDate = Convert.ToDateTime(selectedRow.Cells[1].Value);
                invoice.CustomerID = Convert.ToInt32(selectedRow.Cells[2].Value);
                customComb.SelectedValue = invoice.CustomerID.ToString();
                textBox3.Text = invoice.InvoiceDate.ToString();
                textBox1.Text = invoice.ID.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
            string.IsNullOrEmpty(textBox3.Text.Trim()) ||
                customComb.SelectedValue == null)
            {
                MessageBox.Show("Please Fill ALL!!");
            }
            else
            {
                //invoice.ID = Convert.ToInt32(textBox1.Text);
                invoice.InvoiceDate = Convert.ToDateTime(textBox3.Text);
                invoice.CustomerID = Convert.ToInt32(customComb.SelectedValue);

                int rowsAffected = BusinessLogicLAyer.BLL.InsertInvoices(invoice);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Added Successfully");
                    dt = BusinessLogicLAyer.BLL.GetInvoices();
                    InvoicesGrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Errror Try Again!!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim())
                 ||
             string.IsNullOrEmpty(textBox3.Text.Trim()) ||
                 customComb.SelectedValue == null)
            {
                MessageBox.Show("Please Fill ALL!!");
            }
            else
            {
                invoice.ID = Convert.ToInt32(textBox1.Text);
                invoice.InvoiceDate = Convert.ToDateTime(textBox3.Text);
                invoice.CustomerID = Convert.ToInt32(customComb.SelectedValue);
                int rowsAffected = BusinessLogicLAyer.BLL.UpdateInvoices(invoice);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Updated Successfully");
                    dt = BusinessLogicLAyer.BLL.GetInvoices();
                    InvoicesGrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Errror Try Again!!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) ||
            string.IsNullOrEmpty(textBox3.Text.Trim()) ||
                customComb.SelectedValue == null)
            {
                MessageBox.Show("Please Fill ALL!!");
            }
            else
            {
                



                invoice.ID = Convert.ToInt32(textBox1.Text);
                //invoice.InvoiceDate = Convert.ToDateTime(textBox3.Text);
                //invoice.CustomerID = Convert.ToInt32(customComb.SelectedValue);
                int rowsAffected = BusinessLogicLAyer.BLL.DeleteInvoices(invoice.ID);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Deleted Successfully");
                    dt = BusinessLogicLAyer.BLL.GetInvoices();
                    InvoicesGrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Errror Try Again!!");
                }
            }
        }

        public static void Syncinvoices(DataTable dt)
        {

        }

        private void InvoicesGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow selectedRow = InvoicesGrid.Rows[e.RowIndex];
                invoice.ID = Convert.ToInt32(selectedRow.Cells[0].Value);
                invoice.InvoiceDate = Convert.ToDateTime(selectedRow.Cells[1].Value);
                invoice.CustomerID = Convert.ToInt32(selectedRow.Cells[2].Value.ToString());
                textBox1.Text = invoice.ID.ToString();
                textBox3.Text = invoice.InvoiceDate.ToString();
                customComb.SelectedValue = Convert.ToInt32(customComb.SelectedValue);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void Invoices_v_Load(object sender, EventArgs e)
        {
            dt = BusinessLogicLAyer.BLL.GetInvoices();
            InvoicesGrid.DataSource = dt;

            dt2 = BusinessLogicLAyer.BLL.GetCustomers();
            customComb.DataSource = dt2;
            customComb.DisplayMember = "CustomerName";
            customComb.ValueMember = "CustomerID";


        }

        private void Syncinvoices(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = Data_Access_Layer.DBManager.GetInvoicesDataAdapter();

            try
            {
                adapter.Update(dt);
                MessageBox.Show("Data Saved!!");
            }
            catch (Exception ex)
            {
                throw new Exception("Error syncing data: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearData();
        }

        public void clearData()
        {
            textBox1.Text = "";
            textBox3.Text = "";
            customComb.SelectedValue = -1;
        }
    }
}


