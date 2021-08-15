﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    class Vendor : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; } = DateTime.Now;
        public string Name { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
    }
}
