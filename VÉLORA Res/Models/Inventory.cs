using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VÉLORA_Res.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }

        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int MinimumStock { get; set; }
        public DateTime LastUpdated  { get; set; }
    }
}
