using System;

namespace Final.Models
{
    class InvoiceDetail : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public int InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }
        public int ProductId { get; set; }
        public virtual Product product { get; set; }
        public int QuantityPurchased { get; set; }

    }
}
