namespace StrongFitGym.Models
{
    public class Training
    {
        public int TrainingID { get; set; }
        public int StudentID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }
        public Student Student { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
    }
}

