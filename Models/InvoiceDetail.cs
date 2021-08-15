using System;

namespace Final.Models
{
    class InvoiceDetail : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; } = DateTime.Now;
        public virtual Invoice Invoice { get; set; }
        public virtual Product product { get; set; }
        public int QuantityPurchased { get; set; }

    }
}
