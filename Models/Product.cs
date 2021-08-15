using System;

namespace Final.Models
{
    class Product : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
