﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeatDeptOrderSystem.Models
{
    public class User : IdentityUser
    {
       
        public string UserId { get; set; }
        [NotMapped]
        public IList<string> RoleNames { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
       


    }
}
