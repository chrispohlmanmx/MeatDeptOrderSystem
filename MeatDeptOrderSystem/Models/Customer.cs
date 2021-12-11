using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeatDeptOrderSystem.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage="Please enter a First Name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Please enter a Last Name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Please enter a Phone Number.")]
        [StringLength(10)]
        public string Phone { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public ICollection<OrderItem> OrderItems { get; set; }

        
    }
}
