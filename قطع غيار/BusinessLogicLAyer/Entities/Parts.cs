using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLAyer.Entities
{

   

    public class Parts
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int SuplierID { get; set; }

        public int CategoryID { get; set; }

    }
}
