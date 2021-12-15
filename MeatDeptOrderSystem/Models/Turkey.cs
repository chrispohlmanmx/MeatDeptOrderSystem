using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeatDeptOrderSystem.Models
{
    public class Turkey : OrderItem
    {
        public string FreshOrFrozen { get; set; }
    }
}
