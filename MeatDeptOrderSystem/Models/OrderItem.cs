using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeatDeptOrderSystem.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }

        [Required(ErrorMessage = "Please enter a First Name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a Last Name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a Phone Number.")]
        [StringLength(10)]
        public string Phone { get; set; }

        public string FullName => $"{FirstName} {LastName}";

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
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime pickupDate { get; set; }

        public DateTime orderedOnDate { get; set; }


        public string LocatedIn { get; set; }

        public string CuttingInstructions { get; set; }

        public string PackagingInstructions { get; set; }

        public string OtherComments { get; set; }

        public bool IsReady { get; set; }

        public bool IsOnOrder { get; set; }

        public bool IsComplete { get; set; }

        public string Status { get; set; }

        private bool IsOverDue(DateTime date)
        {
            date = this.pickupDate;
            if(pickupDate < DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setStatus()
        {
            this.Status= "Order Placed";
            if (this.IsComplete)
            {
                this.Status = "Complete";
            }else if (this.IsReady)
            {
                this.Status = "Ready";
            }else if (this.IsOnOrder)
            {
                this.Status = "On Order";
            }else if (IsOverDue(this.pickupDate)) {
                this.Status = "Overdue";
            }
        }

       


    }
}
