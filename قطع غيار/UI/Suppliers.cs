using BusinessLogicLAyer.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UI
{
    public partial class Suppliers : Form
    {
        DataTable dt = new DataTable();
        Supplier SupplierDetails = new Supplier();
        public Suppliers()
        {
            InitializeComponent();
        }

        private void CPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            dt = BusinessLogicLAyer.BLL.GetAllSuppliers();
            SuppliersGrid.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SName.Text.Trim())
            ||
           string.IsNullOrEmpty(SEmail.Text.Trim()) ||
               string.IsNullOrEmpty(SPhone.Text.Trim()))
            {
                MessageBox.Show("Please Fill ALL!!");
            }
            else
            {
                if (int.TryParse(textBox5.Text.Trim(), out int supplierId))
                {
                    SupplierDetails.ID = supplierId;
                }
                else
                {
                    SupplierDetails.ID = 0;
                }
                //SupplierDetails.ID = Convert.ToInt32(textBox5.Text);
                SupplierDetails.Name = SName.Text;
                SupplierDetails.Email = SEmail.Text;
                SupplierDetails.Phone = SPhone.Text;
                int rowsAffected = BusinessLogicLAyer.BLL.InsertSuppliers(SupplierDetails);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Added Successfully");
                    dt = BusinessLogicLAyer.BLL.GetAllSuppliers();
                    SuppliersGrid.DataSource = dt;
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
            if (string.IsNullOrEmpty(SName.Text.Trim())
            ||
           string.IsNullOrEmpty(SEmail.Text.Trim()) ||
               string.IsNullOrEmpty(SPhone.Text.Trim()))
            {
                MessageBox.Show("Please Fill ALL!!");
            }
            else
            {
                if (int.TryParse(textBox5.Text.Trim(), out int supplierId))
                {
                    SupplierDetails.ID = supplierId;
                }
                else
                {
                    SupplierDetails.ID = 0;
                }
                //SupplierDetails.ID = Convert.ToInt32(textBox5.Text);
                SupplierDetails.Name = SName.Text;
                SupplierDetails.Email = SEmail.Text;
                SupplierDetails.Phone = SPhone.Text;
                int rowsAffected = BusinessLogicLAyer.BLL.UpdateSuppliers(SupplierDetails);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Updated Successfully");
                    dt = BusinessLogicLAyer.BLL.GetAllSuppliers();
                    SuppliersGrid.DataSource = dt;
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
            if (string.IsNullOrEmpty(SName.Text.Trim())
                       ||
                      string.IsNullOrEmpty(SEmail.Text.Trim()) ||
                          string.IsNullOrEmpty(SPhone.Text.Trim()))
            {
                MessageBox.Show("Please Fill ALL!!");
            }
            else
            {
                if (int.TryParse(textBox5.Text.Trim(), out int supplierId))
                {
                    SupplierDetails.ID = supplierId;
                }
                else
                {
                    SupplierDetails.ID = 0;
                }
                //SupplierDetails.ID = Convert.ToInt32(textBox5.Text);
                SupplierDetails.Name = SName.Text;
                SupplierDetails.Email = SEmail.Text;
                SupplierDetails.Phone = SPhone.Text;
                int rowsAffected = BusinessLogicLAyer.BLL.DeleteSuppliers(SupplierDetails);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Deleted Successfully");
                    dt = BusinessLogicLAyer.BLL.GetAllSuppliers();
                    SuppliersGrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Errror Try Again!!");
                }
                clearData();
            }
        }

        public void clearData()
        {
            textBox5.Text = "";
            SName.Text = "";
            SEmail.Text = "";
            //CAddress.Text = "";
            SPhone.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                BusinessLogicLAyer.BLL.SyncSuppliers(dt);
                dt = BusinessLogicLAyer.BLL.GetAllSuppliers();
                SuppliersGrid.DataSource = dt;
                MessageBox.Show("Data Saved!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorrr!!!");
            }

        }

        private void SuppliersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow selectedRow = SuppliersGrid.Rows[e.RowIndex];
                SupplierDetails.ID = Convert.ToInt32(selectedRow.Cells[0].Value);
                SupplierDetails.Name = selectedRow.Cells[1].Value.ToString();
                SupplierDetails.Phone = selectedRow.Cells[2].Value.ToString();
                SupplierDetails.Email = selectedRow.Cells[3].Value.ToString();
                textBox5.Text = SupplierDetails.ID.ToString();
                SName.Text = SupplierDetails.Name;
                SEmail.Text = SupplierDetails.Email;
                SPhone.Text = SupplierDetails.Phone;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }

}
