using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAlpha.Data
{
    public class Workout
    {
        [Key]
        public int WorkoutID { get; set; }
        [Required]
        public string WorkoutName { get; set; }
        //FK
        public string Workout_Type_ID { get; set; }
    }
}
