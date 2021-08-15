using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    class Product : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int QuantityOnHand { get; set; }

        public Product(int id, string name, string description, double price, int quantityOnHand)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            QuantityOnHand = quantityOnHand;
        }
    }
}
