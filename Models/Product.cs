using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    class Product
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

    }
}
