using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    interface Model
    {
        int Id { get; set; }
        DateTime? CreatedAt { get; }

    }
}
