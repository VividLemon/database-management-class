using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    class PurchaseOrderDetail : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; } = DateTime.Now;
        public virtual Product Product { get; set; }
        public int QuantityPurchased { get; set; }

    }
}
