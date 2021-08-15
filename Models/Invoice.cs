using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    class Invoice : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; } = DateTime.Now;
        public virtual Customer customer { get; set; }

        public Invoice(int id, Customer customer)
        {
            Id = id;
            this.customer = customer;
        }
    }
}
