using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAlpha.Data
{
    public abstract class BaseIdentity
    {
        [Key]
        [Required(ErrorMessage = "Missing primary key value")]
        public int ID { get; set; }

        [Display(Name = "Last Modified")]
        public DateTime LastModified { get; set; }
    }
}
