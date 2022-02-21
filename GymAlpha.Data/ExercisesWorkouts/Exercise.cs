namespace GymAlpha.Data
{
    public class Exercise : BaseIdentity
    {
        public string ExerciseName { get; set; }
        public int ExerciseEquipmentID { get; set; }
        public int ExerciseTypeID { get; set; }
    }
}