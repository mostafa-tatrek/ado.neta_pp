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
        public string Description { get; set; }
        public string Mount { get; set; }
        public int Price { get; set; }
        public int SuplierID { get; set; }

    }
}
