using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    class BusinessInformation : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; } = DateTime.Now;
        public decimal Longitute { get; set; }
        public decimal Latitude { get; set; }
        public virtual BusinessType Type { get; set; }

        public BusinessInformation(int id, decimal longitute, decimal latitude, BusinessType type)
        {
            Id = id;
            Longitute = longitute;
            Latitude = latitude;
            Type = type;
        }
    }
}
