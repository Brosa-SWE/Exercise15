using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class GymClass
    {

        /*
         int Id { get; set; }
● string Name { get; set; }
● DateTime StartTime { get; set; }
● TimeSpan Duration { get; set; }
● DateTime EndTime { get { return StartTime + Duration} }
● Strimeng Description { get; set; }
         */

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }

        public TimeSpan Duration { get; set; }

        public DateTime EndTime { get { return StartTime + Duration; } }

        public string Description { get; set; }

        public ICollection<ApplicationUserGymClass> Members { get; set; }
    }
}
