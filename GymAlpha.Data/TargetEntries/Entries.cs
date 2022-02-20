using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAlpha.Data.TargetEntries
{
    public class Entries
    {
        [Key]
        public int EntriesID { get; set; }
        //FK
        public int Log_ID { get; set; }
        //FK
        public int Junction_ID { get; set; }
        public int WarmupSets { get; set; }
        public int SetNumber { get; set; }
        public int Weight { get; set; }
        public int Reps { get; set; }
        public DateTime TimeRecorded { get; set; }
    }
}
