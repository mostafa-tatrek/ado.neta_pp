using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLAyer.Entities
{
    public class InvoicesDetails
    {
        public int ID { get; set; }

        public long TotalPrice { get; set; }

        public int Quantity { get; set; }
        public int PartID { get; set; }

        public int InvoiceID { get; set; }
    }
}
