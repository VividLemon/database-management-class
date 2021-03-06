using System;

namespace Final.Models
{
    class Invoice : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public int CustomerId { get; set; }
        public virtual Customer customer { get; set; }
    }
}
