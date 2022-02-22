using System.Collections.Generic;

namespace GymAlpha.Data
{
    //Target for each exercise in a specific workout
    public class Target : BaseIdentity
    {
        public Target()
        {
            Junction = new HashSet<Junction>();
        }

        public int WarmUpSet { get; set; }
        public int SetNumber { get; set; }
        public int MinReps { get; set; }
        public int MaxReps { get; set; }

        public virtual ICollection<Junction> Junction { get; set; }
    }
}