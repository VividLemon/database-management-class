using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    class BusinessIssue
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public string Issue { get; set; }
        public virtual BusinessInformation Business { get; set; }
    }
}
