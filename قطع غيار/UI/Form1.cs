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
            Invoices_v invoices = new Invoices_v();
            invoices.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Parts_v parts_V = new Parts_v();
            //parts_V.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }
    }
}
