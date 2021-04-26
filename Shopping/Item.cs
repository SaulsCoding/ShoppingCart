using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Item
    {
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }//uses more memory than double
    }
}
