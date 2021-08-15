using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    class PurchaseOrder : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; } = DateTime.Now;
        public virtual PurchaseOrderDetail PurchaseOrderDetail { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalPaid { get; set; }
        public virtual Vendor Vendor { get; set; }

        public PurchaseOrder(int id, PurchaseOrderDetail purchaseOrderDetail, DateTime purchaseDate, decimal totalPaid, Vendor vendor)
        {
            Id = id;
            PurchaseOrderDetail = purchaseOrderDetail;
            PurchaseDate = purchaseDate;
            TotalPaid = totalPaid;
            Vendor = vendor;
        }
    }
}
