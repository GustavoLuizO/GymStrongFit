namespace StrongFitGym.Models
{
    public class Exercise
    {
        public int ExerciseID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public ICollection<Training> Trainings { get; set; }
    }
}
