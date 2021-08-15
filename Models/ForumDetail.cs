using System;

namespace Final.Models
{
    class ForumDetail : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public string Content { get; set; }
        public virtual Forum Forum { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
