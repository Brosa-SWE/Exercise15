﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class ApplicationUser : IdentityUser
    {

        public ICollection<ApplicationUserGymClass> Classes { get; set; }
    }
}
