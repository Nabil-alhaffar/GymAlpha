using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymAlpha.Data
{
    [Table("Exercise")]
    public class Exercise : BaseIdentity
    {
        public Exercise()
        {
            ExerciseType = new HashSet<ExerciseType>();

            ExerciseEquipment = new HashSet<ExerciseEquipment>();
        }

        public int JunctionID { get; set; }
        public virtual Junction Junction { get; set; }

        [Required]
        [StringLength(15)]
        public string ExerciseName { get; set; }
        public virtual ICollection<ExerciseEquipment> ExerciseEquipment { get; set; }
        public virtual ICollection<ExerciseType> ExerciseType { get; set; }
    }
}