using System;
using System.Collections.Generic;

namespace GymAlpha.Data
{
    public class Junction : BaseIdentity
    {
        public Junction()
        {
            Exercise = new HashSet<Exercise>();

            Workout = new HashSet<Workout>();
        }

        public virtual ICollection<Exercise> Exercise { get; set; }
        public virtual ICollection<Workout> Workout { get; set; }

        public virtual Target Target { get; set; }
        public virtual Entries Entries { get; set; }
    }
}