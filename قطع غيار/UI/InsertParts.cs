using BusinessLogicLAyer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UI
{
    public partial class InsertParts : Form
    {
        DataTable dt, dt2, dt3;
        Parts part = new Parts();
        public InsertParts()
        {
            InitializeComponent();
        }

        private void InsertParts_Load(object sender, EventArgs e)
        {
            dt3 = BusinessLogicLAyer.BLL.GetAllParts();
            PArtsGrid.DataSource = dt3;





            dt = BusinessLogicLAyer.BLL.GetAllSuppliers();
            SuppliersComb.DataSource = dt;
            SuppliersComb.DisplayMember = "SupplierName";
            SuppliersComb.ValueMember = "SuppliersID";


            dt2 = BusinessLogicLAyer.BLL.GetAllGategories();
            CategoriesComb.DataSource = dt2;
            CategoriesComb.ValueMember = "categoryID";
            CategoriesComb.DisplayMember = "categoriesName";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PName.Text.Trim()) || string.IsNullOrEmpty(PPrice.Text.Trim()) || string.IsNullOrEmpty(PQuantity.Text.Trim()) || SuppliersComb.SelectedValue == null || CategoriesComb.SelectedValue == null)
            {
                MessageBox.Show("Please Fill All");
            }
        }

        private void PArtsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow selectedRow = PArtsGrid.Rows[e.RowIndex];
                part.PartID = Convert.ToInt32(selectedRow.Cells[0].Value);
                part.Name = selectedRow.Cells[1].Value.ToString();
                part.Price = Convert.ToInt32(selectedRow.Cells[2].Value);
                part.Quantity = Convert.ToInt32(selectedRow.Cells[3].Value);
                part.SuplierID = Convert.ToInt32(selectedRow.Cells[4].Value);
                part.CategoryID = Convert.ToInt32(selectedRow.Cells[5].Value);

                textBox5.Text = part.PartID.ToString();
                PName.Text = part.Name;
                PPrice.Text = part.Price.ToString();
                PQuantity.Text = part.Quantity.ToString();
                SuppliersComb.SelectedValue = Convert.ToInt32(part.SuplierID);
                CategoriesComb.SelectedValue = Convert.ToInt32(part.CategoryID);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        public void clearData()
        {
            textBox5.Text = "";
            PName.Text = "";
            PPrice.Text = "";
            PQuantity.Text = "";
            SuppliersComb.SelectedIndex = -1;
            CategoriesComb.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PName.Text.Trim())
                ||
            string.IsNullOrEmpty(PPrice.Text.Trim()) ||
                string.IsNullOrEmpty(PQuantity.Text.Trim()) ||

                    SuppliersComb.SelectedValue == null ||
                    CategoriesComb.SelectedValue == null)
            {
                MessageBox.Show("Please Fill ALL!!");
            }
            else
            {
                if (int.TryParse(textBox5.Text.Trim(), out int partId))
                {
                    part.PartID = partId;
                }
                else
                {
                    part.PartID = 0;
                }
                part.Name = PName.Text;
                part.Price = Convert.ToInt32(PPrice.Text);
                part.Quantity = Convert.ToInt32(PQuantity.Text);
                part.SuplierID = Convert.ToInt32(SuppliersComb.SelectedValue);
                part.CategoryID = Convert.ToInt32(CategoriesComb.SelectedValue);
                int rowsAffected = BusinessLogicLAyer.BLL.UpdateParts(part);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Updated Successfully");
                    dt = BusinessLogicLAyer.BLL.GetParts();
                    PArtsGrid.DataSource = dt;
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
            if (string.IsNullOrEmpty(PName.Text.Trim())
                ||
            string.IsNullOrEmpty(PPrice.Text.Trim()) ||
                string.IsNullOrEmpty(PQuantity.Text.Trim()) ||

                    SuppliersComb.SelectedValue == null ||
                    CategoriesComb.SelectedValue == null)
            {
                MessageBox.Show("Please Fill ALL!!");
            }
            else
            {
                if (int.TryParse(textBox5.Text.Trim(), out int partId))
                {
                    part.PartID = partId;
                }
                else
                {
                    part.PartID = 0;
                }
                part.Name = PName.Text;
                part.Price = Convert.ToInt32(PPrice.Text);
                part.Quantity = Convert.ToInt32(PQuantity.Text);
                part.SuplierID = Convert.ToInt32(SuppliersComb.SelectedValue);
                part.CategoryID = Convert.ToInt32(CategoriesComb.SelectedValue);
                int rowsAffected = BusinessLogicLAyer.BLL.DeleteParts(part.PartID);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Deleted Successfully");
                    dt = BusinessLogicLAyer.BLL.GetParts();
                    PArtsGrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Errror Try Again!!");
                }
                clearData();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLogicLAyer.BLL.SyncParts(dt);
                dt = BusinessLogicLAyer.BLL.GetParts();
                PArtsGrid.DataSource = dt;
                MessageBox.Show("Data Saved!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorrr!!!");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PName.Text.Trim())
                ||
            string.IsNullOrEmpty(PPrice.Text.Trim()) ||
                string.IsNullOrEmpty(PQuantity.Text.Trim()) ||

                    SuppliersComb.SelectedValue == null ||
                    CategoriesComb.SelectedValue == null)
            {
                MessageBox.Show("Please Fill ALL!!");
            }
            else
            {
                if (int.TryParse(textBox5.Text.Trim(), out int partId))
                {
                    part.PartID = partId;
                }
                else
                {
                    part.PartID = 0;
                }
                part.Name = PName.Text;
                part.Price = Convert.ToInt32(PPrice.Text);
                part.Quantity = Convert.ToInt32(PQuantity.Text);
                part.SuplierID = Convert.ToInt32(SuppliersComb.SelectedValue);
                part.CategoryID = Convert.ToInt32(CategoriesComb.SelectedValue);
                int rowsAffected = BusinessLogicLAyer.BLL.InsertParts(part);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Added Successfully");
                    dt = BusinessLogicLAyer.BLL.GetParts();
                    PArtsGrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Errror Try Again!!");
                }
                clearData();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
