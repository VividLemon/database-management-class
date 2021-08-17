using System;

namespace Final.Models
{
    class Customer : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public string Name { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public virtual User User { get; set; }
    }
}
