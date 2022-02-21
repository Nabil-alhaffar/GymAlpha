namespace GymAlpha.Data
{
    //Target for each exercise in a specific workout
    public class Target : BaseIdentity
    {
        public int JunctionID { get; set; }
        public int WarmUpSet { get; set; }
        public int SetNumber { get; set; }
        public int MinReps { get; set; }
        public int MaxReps { get; set; }
    }
}