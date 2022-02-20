using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAlpha.Data
{
    public class Exercise
    {
        [Key]
        public int ExerciseID { get; set; }
        [Required]
        public string ExerciseName { get; set; }
        //FK
        public string Exercise_Type_ID { get; set; }
        //FK
        public string Exercie_Equipment_ID { get; set; }
    }
}
