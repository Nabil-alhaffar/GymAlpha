using System;
using System.Collections.Generic;

namespace GymAlpha.Data
{
    public class Log : BaseIdentity
    {
        public Log()
        {
            Workout = new HashSet<Workout>();
        }

        public virtual ICollection<Workout> Workout { get; set; }

        public int EntriesID { get; set; }
        public virtual Entries Entries { get; set; }

        public DateTime Date { get; set; }
    }
}