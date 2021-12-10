using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeatDeptOrderSystem.Models
{
    public class OrderItem
    {
        public int OrderID { get; set; }

        [Required]
        public Customer customer { get; set; }

        [Required]
        public User user { get; set; }

        [Required(ErrorMessage ="Please enter a name for the item.")]
        public string ItemName { get; set; }

        public string ItemBrand { get; set; }

        [Required(ErrorMessage ="Please enter the quantity being ordered.")]
        [Range(1,1000)]
        public int Quantity { get; set; }

        [Range(0,1000)]
        public double Weight { get; set; }

        [Required(ErrorMessage ="Please enter the Date for the order to be picked up.")]
        public DateTime pickupDate { get; set; }

        public DateTime orderedOnDate { get; set; }


        public string LocatedIn { get; set; }

        public string CuttingInstructions { get; set; }

        public string PackagingInstructions { get; set; }

        public string OtherComments { get; set; }

        public bool IsReady { get; set; }

        public bool IsOnOrder { get; set; }

        public bool IsComplete { get; set; }



    }
}
