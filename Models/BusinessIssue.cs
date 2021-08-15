using System;

namespace Final.Models
{
    class BusinessIssue : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; } = DateTime.Now;
        public string Issue { get; set; }
        public virtual BusinessInformation Business { get; set; }

    }
}
