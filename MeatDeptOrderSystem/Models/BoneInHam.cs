using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeatDeptOrderSystem.Models
{
    public class BoneInHam : OrderItem
    {
        public string HalfOrWhole { get; set; }
        public string HamType { get; set; }
    }
}
