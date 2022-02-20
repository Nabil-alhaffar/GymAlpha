using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAlpha.Data.JunctionLog
{
    public class Log
    {
        [Key]
        public int LogID { get; set; }
        //FK
        public int Workout_ID { get; set; }
        public DateTime Date { get; set; }
    }
}
