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

        public int TargetID { get; set; }
        public virtual Target Target { get; set; }

        public int EntriesID { get; set; }
        public virtual Entries Entries { get; set; }
    }
}