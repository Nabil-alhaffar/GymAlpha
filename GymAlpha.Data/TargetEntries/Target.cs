using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAlpha.Data.TargetEntries
{
    public class Target
    {
        [Key]
        public int TargetID { get; set; }
        //FK
        public int Junction_ID { get; set; }
        public int WarmupSets { get; set; }
        public int SetNumber { get; set; }
        public int MinReps { get; set; }
        public int MaxReps { get; set; }
    }
}
