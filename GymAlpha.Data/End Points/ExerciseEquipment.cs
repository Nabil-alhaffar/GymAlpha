using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAlpha.Data
{
    public class ExerciseEquipment
    {
        [Key]
        public string ExerciseEquipmentID { get; set; }
    }
}
