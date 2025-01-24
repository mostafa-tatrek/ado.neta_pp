namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers formCustomers = new Customers();
            formCustomers.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Suppliers formSuppliers = new Suppliers();
            formSuppliers.Show();
            
        }
    }
}
