using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class ApplicationUserGymClass
    {

        public int ApplicationUserGymClassId { get; set; }

        public int ApplicationUserId { get; set; }

        public int GymClassId { get; set; }
    }
}
