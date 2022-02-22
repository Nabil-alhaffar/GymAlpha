using System.Collections.Generic;

namespace GymAlpha.Data
{
    public class Workout : BaseIdentity 
    {
        public Workout()
        {
            WorkoutType = new HashSet<WorkoutType>();
        }

        public int JunctionID { get; set; }
        public virtual Junction Junction { get; set; }

        public string WorkoutName { get; set; }
        public virtual ICollection<WorkoutType> WorkoutType { get; set; }
    }
}