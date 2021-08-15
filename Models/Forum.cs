﻿using System;

namespace Final.Models
{
    class Forum : Model
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; } = DateTime.Now;
        public string Name { get; set; }
    }
}
