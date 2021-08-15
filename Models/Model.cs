using System;

namespace Final.Models
{
    interface Model
    {
        int Id { get; set; }
        DateTime? CreatedAt { get; set; }

    }
}
