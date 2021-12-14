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
        public string Phone { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public int UserId { get; set; }
        public User User { get; set; }

        [Required(ErrorMessage ="Please enter a name for the item.")]
        public string ItemName { get; set; }

        public string ItemBrand { get; set; }

        [Required(ErrorMessage ="Please enter the quantity being ordered.")]
        [Range(1,1000)]
        public int Quantity { get; set; }

        
        public string Weight { get; set; }

        [Required(ErrorMessage ="Please enter the Date for the order to be picked up.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime pickupDate { get; set; }

        public DateTime orderedOnDate { get; set; }

        [Required(ErrorMessage ="Please Select a Status.")]
        public string StatusId { get; set; }
        public Status Status { get; set; }
        
        [Required(ErrorMessage ="Please select a location.")]
        public string LocationId { get; set; }
        public Location Location { get; set; }

        public string CuttingInstructions { get; set; }

        public string PackagingInstructions { get; set; }

        public string OtherComments { get; set; }



        public bool IsOverDue =>
            StatusId != "complete" && pickupDate < DateTime.Today;
        

       


    }
}
