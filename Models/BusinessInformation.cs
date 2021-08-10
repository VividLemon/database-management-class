using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    class BusinessInformation
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public decimal Longitute { get; set; }
        public decimal Latitude { get; set; }
        public virtual BusinessType Type { get; set; }
    }
}
