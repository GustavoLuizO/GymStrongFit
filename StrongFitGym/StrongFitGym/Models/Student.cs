using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StrongFitGym.Models
{
    [Table("Student")]
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public DateTime birthdate { get; set; }
        public string Email { get; set; }
        public string Instagram { get; set; }
        public string Phone { get; set; }
        public int PersonalID { get; set; }
        public string Comments { get; set; }
        public Personal Personal { get; set; }
        public ICollection<Training> Trainings { get; set; }
    }
}
