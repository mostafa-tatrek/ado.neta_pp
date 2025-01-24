using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLAyer.Entities;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class Reports : Form
    {

        DataTable dt;
        public Reports()
        {
            InitializeComponent();
        }
        
        private void ReportGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            dt = BusinessLogicLAyer.BLL.GetReports();
            ReportGrid.DataSource = dt;

        }
    }
}
