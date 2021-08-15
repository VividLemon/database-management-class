using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    class InvoiceDetail : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; } = DateTime.Now;
        public virtual Invoice Invoice { get; set; }
        public virtual Product product { get; set; }
        public int QuantityPurchased { get; set; }

        public InvoiceDetail(int id, Invoice invoice, Product product, int quantityPurchased)
        {
            Id = id;
            Invoice = invoice;
            this.product = product;
            QuantityPurchased = quantityPurchased;
        }
    }
}
