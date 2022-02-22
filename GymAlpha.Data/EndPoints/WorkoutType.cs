using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAlpha.Data
{
    public class WorkoutType : BaseIdentity 
    {
        public string WorkoutTypeName { get; set; }
        public int WorkoutID { get; set; }
        public virtual Workout Workout { get; set; }
    }
}
