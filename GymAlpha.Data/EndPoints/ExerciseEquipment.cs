using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAlpha.Data
{
    [Table("Exercise Equipment")]
    public class ExerciseEquipment : BaseIdentity
    {
        public string ExerciseEquipmentName { get; set; }
        public int ExerciseID { get; set; }
        public virtual Exercise Exercise { get; set; }
    }
}
