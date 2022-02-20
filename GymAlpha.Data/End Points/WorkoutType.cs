using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAlpha.Data
{
    public class WorkoutType
    {
        [Key]
        public string WorkOutTypeID { get; set; }
    }
}
