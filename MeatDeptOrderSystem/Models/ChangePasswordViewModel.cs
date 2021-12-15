using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MeatDeptOrderSystem.Models
{
    public class ChangePasswordViewModel
    {
        public string Username { get; set; }
        
        [Required(ErrorMessage ="Please enter your old password.")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage ="Please enter a new password")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
    }
}
