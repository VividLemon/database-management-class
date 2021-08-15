using System;

namespace Final.Models
{
    class PurchaseOrder : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; } = DateTime.Now;
        public DateTime PurchaseDate { get; set; }
        public decimal TotalPaid { get; set; }
        public virtual Vendor Vendor { get; set; }

    }
}
