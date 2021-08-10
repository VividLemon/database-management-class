using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    class PurchaseOrder
    {
        public int id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public virtual PurchaseOrderDetail PurchaseOrderDetail { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalPaid { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
