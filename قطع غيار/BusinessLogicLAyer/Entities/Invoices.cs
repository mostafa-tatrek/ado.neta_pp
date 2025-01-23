using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLAyer.Entities
{
    public class Invoices
    {
        public int ID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int CustomerID { get; set; }

    }
}
