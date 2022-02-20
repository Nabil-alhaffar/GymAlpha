using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAlpha.Data
{
    public class ExerciseType
    {
        [Key]
        public string ExerciseTypeID { get; set; }
    }
}
