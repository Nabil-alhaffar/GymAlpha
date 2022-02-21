using System;

namespace GymAlpha.Data
{
    public class Entries : BaseIdentity
    {
        public int LogID { get; set; }
        public int JunctionID { get; set; }
        public int WarmUpSet { get; set; }
        public int SetNumber { get; set; }
        public int Weight { get; set; }
        public int Reps { get; set; }
        public DateTime TimeRecorded { get; set; }
    }
}