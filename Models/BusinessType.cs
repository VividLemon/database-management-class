using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    class BusinessType : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; } = DateTime.Now;
        public string Type { get; set; }

        public BusinessType(int id, string type)
        {
            Id = id;
            Type = type;
        }
    }
}
