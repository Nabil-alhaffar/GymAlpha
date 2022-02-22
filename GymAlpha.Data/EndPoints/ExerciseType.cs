using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAlpha.Data
{
    [Table("Exercise Type")]
    public class ExerciseType : BaseIdentity
    {
        public string ExerciseTypeName { get; set; }
        public int ExerciseID { get; set; }
        public virtual Exercise Exercise { get; set; }
    }
}
