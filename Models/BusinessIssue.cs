using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    class BusinessIssue : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; } = DateTime.Now;
        public string Issue { get; set; }
        public virtual BusinessInformation Business { get; set; }

        public BusinessIssue(int id, string issue, BusinessInformation business)
        {
            Id = id;
            Issue = issue;
            Business = business;
        }
    }
}
