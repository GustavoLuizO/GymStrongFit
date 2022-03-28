using Microsoft.EntityFrameworkCore;
namespace StrongFitGym.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public DbSet<Training> Trainings { get; set; }
    }
}
