using System;
using System.Collections.Generic;

namespace GymAlpha.Data
{
    public class Log : BaseIdentity
    {
        public Log()
        {
            Exercise = new HashSet<Exercise>();

            Workout = new HashSet<Workout>();
        }

        public virtual ICollection<Exercise> Exercise { get; set; }
        public virtual ICollection<Workout> Workout { get; set; }

        public DateTime Date { get; set; }

        public virtual Entries Entries { get; set; }
    }
}