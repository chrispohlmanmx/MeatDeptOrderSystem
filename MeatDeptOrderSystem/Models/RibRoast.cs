using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeatDeptOrderSystem.Models
{
    public class RibRoast : OrderItem
    {
        public string BoneInOrBoneless { get; set; }
        
        public string MeatGrade { get; set; }

        public bool CutAndTied { get; set; }

    }
}
