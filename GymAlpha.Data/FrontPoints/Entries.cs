using System;
using System.Collections.Generic;

namespace GymAlpha.Data
{
    public class Entries : BaseIdentity
    {
        public Entries()
        {
            Log = new HashSet<Log>();

            Junction = new HashSet<Junction>();
        }

        public int JunctionID { get; set; }
        public int WarmUpSet { get; set; }
        public int SetNumber { get; set; }
        public int Weight { get; set; }
        public int Reps { get; set; }
        public DateTime TimeRecorded { get; set; }

        public virtual ICollection<Log> Log { get; set; }
        public virtual ICollection<Junction> Junction { get; set; }
    }
}