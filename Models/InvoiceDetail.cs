using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    class InvoiceDetail
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public virtual Invoice Invoice { get; set; }
        public virtual Product product { get; set; }
        public int QuantityPurchased { get; set; }
    }
}
