using System;

namespace Final.Models
{
    class BusinessInformation : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public decimal Longitute { get; set; }
        public decimal Latitude { get; set; }
        public virtual BusinessType Type { get; set; }

    }
}
