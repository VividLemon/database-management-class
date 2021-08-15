using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    class ForumDetail : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; } = DateTime.Now;
        public string Content { get; set; }
        public virtual Forum Forum { get; set; }
        public virtual Customer Customer { get; set; }

        public ForumDetail(int id, string content, Forum forum, Customer customer)
        {
            Id = id;
            Content = content;
            Forum = forum;
            Customer = customer;
        }
    }
}
