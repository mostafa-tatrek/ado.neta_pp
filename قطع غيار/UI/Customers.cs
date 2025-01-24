using BusinessLogicLAyer.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class Customers : Form
    {
        DataTable dt;
        Customer customer = new Customer();
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            dt = BusinessLogicLAyer.BLL.GetCustomers();
            CustomersGrid.DataSource = dt;
        }

        private void CustomersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CName.Text.Trim())
                ||
            string.IsNullOrEmpty(CEmail.Text.Trim()) ||
                string.IsNullOrEmpty(CPhone.Text.Trim()) ||
                string.IsNullOrEmpty(CAddress.Text.Trim()))
            {
                MessageBox.Show("Please Fill ALL!!");
            }
            else
            {
                if (int.TryParse(textBox5.Text.Trim(), out int customerId))
                {
                    customer.CustomerID = customerId;
                }
                else
                {
                    customer.CustomerID = 0;
                }
                //customer.CustomerID = Convert.ToInt32(textBox5.Text);
                customer.CustomerName = CName.Text;
                customer.Email = CEmail.Text;
                customer.Address = CAddress.Text;
                customer.Phone = CPhone.Text;
                int rowsAffected = BusinessLogicLAyer.BLL.InsertCustomers(customer);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Added Successfully");
                    dt = BusinessLogicLAyer.BLL.GetCustomers();
                    CustomersGrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Errror Try Again!!");
                }
                clearData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CName.Text.Trim())
                           ||
                       string.IsNullOrEmpty(CEmail.Text.Trim()) ||
                           string.IsNullOrEmpty(CPhone.Text.Trim()) ||
                           string.IsNullOrEmpty(CAddress.Text.Trim()))
            {
                MessageBox.Show("Please Fill ALL!!");
            }
            else
            {
                if (int.TryParse(textBox5.Text.Trim(), out int customerId))
                {
                    customer.CustomerID = customerId;
                }
                else
                {
                    customer.CustomerID = 0;
                }
                //customer.CustomerID = Convert.ToInt32(textBox5.Text);
                customer.CustomerName = CName.Text;
                customer.Email = CEmail.Text;
                customer.Address = CAddress.Text;
                customer.Phone = CPhone.Text;
                int rowsAffected = BusinessLogicLAyer.BLL.UpdateCustomers(customer);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Updated Successfully");
                    dt = BusinessLogicLAyer.BLL.GetCustomers();
                    CustomersGrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Errror Try Again!!");
                }
                clearData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CName.Text.Trim()) ||
                       string.IsNullOrEmpty(CEmail.Text.Trim()) ||
                           string.IsNullOrEmpty(CPhone.Text.Trim()) ||
                           string.IsNullOrEmpty(CAddress.Text.Trim()))
            {
                MessageBox.Show("Please Fill ALL!!");
            }
            else
            {
                if (int.TryParse(textBox5.Text.Trim(), out int customerId))
                {
                    customer.CustomerID = customerId;
                }
                else
                {
                    customer.CustomerID = 0;
                }
                //customer.CustomerID = Convert.ToInt32(textBox5.Text);
                customer.CustomerName = CName.Text;
                customer.Email = CEmail.Text;
                customer.Address = CAddress.Text;
                customer.Phone = CPhone.Text;
                int rowsAffected = BusinessLogicLAyer.BLL.DeleteCustomer(customer.CustomerID);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Deleted Successfully");
                    dt = BusinessLogicLAyer.BLL.GetCustomers();
                    CustomersGrid.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("Errror Try Again!!");
                }
                clearData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLogicLAyer.BLL.SyncCustomer(dt);
                dt = BusinessLogicLAyer.BLL.GetCustomers();
                CustomersGrid.DataSource = dt;
                MessageBox.Show("Data Saved!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorrr!!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearData();
        }
        public void clearData()
        {
            textBox5.Text = "";
            CName.Text = "";
            CEmail.Text = "";
            CAddress.Text = "";
            CPhone.Text = "";
        }
        private void CustomersGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow selectedRow = CustomersGrid.Rows[e.RowIndex];
                customer.CustomerID = Convert.ToInt32(selectedRow.Cells[0].Value);
                customer.CustomerName = selectedRow.Cells[1].Value.ToString();
                customer.Phone = selectedRow.Cells[2].Value.ToString();
                customer.Address = selectedRow.Cells[3].Value.ToString();
                customer.Email = selectedRow.Cells[4].Value.ToString();
                textBox5.Text = customer.CustomerID.ToString();
                CName.Text = customer.CustomerName;
                CEmail.Text = customer.Email;
                CAddress.Text = customer.Address;
                CPhone.Text = customer.Phone;
            }
        }
    }
}
