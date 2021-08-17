using System;

namespace Final.Models
{
    class BusinessIssue : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public string Issue { get; set; }
        public int BusinessInformationId { get; set; }
        public virtual BusinessInformation Business { get; set; }

    }
}
