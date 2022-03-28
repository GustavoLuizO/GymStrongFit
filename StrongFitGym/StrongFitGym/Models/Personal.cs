namespace StrongFitGym.Models
{
    public class Personal
    {
        public int PersonalID { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
