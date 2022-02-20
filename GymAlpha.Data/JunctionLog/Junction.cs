using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAlpha.Data.JunctionLog
{
    public class Junction
    {
        [Key]
        public int JunctionID { get; set; }
        //FK
        public int Exercise_ID { get; set; }
        //FK
        public int Workout_ID { get; set; }
    }
}
