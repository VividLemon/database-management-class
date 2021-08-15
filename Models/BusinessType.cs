using System;

namespace Final.Models
{
    class BusinessType : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public string Type { get; set; }

    }
}
