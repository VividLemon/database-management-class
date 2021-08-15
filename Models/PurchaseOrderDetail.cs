using System;

namespace Final.Models
{
    class PurchaseOrderDetail : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public virtual Product Product { get; set; }
        public int QuantityPurchased { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }

    }
}
