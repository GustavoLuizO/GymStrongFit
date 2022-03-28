using Microsoft.EntityFrameworkCore;
namespace StrongFitGym.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            Contexto context = app.ApplicationServices.GetRequiredService<Contexto>();

            DateTime date = DateTime.Now;

            context.Database.Migrate();

            if (!context.Personals.Any())
            {
                context.Personals.AddRange(
                    new Personal
                    {
                        Name = "Fabricio",
                        Speciality = "Pernas"
                    });

                context.Exercises.AddRange(
                    new Exercise
                    {
                        Name = "Supino",
                        Category = "Peito",
                        Description = "Levanta barra"
                    });

                context.Trainings.AddRange(
                    new Training
                    {
                        StudentID = 1,
                        Date = date,
                        Hour = date
                    });
                context.Students.AddRange(
                    new Student
                    {
                        Name = "Gustavo",
                        birthdate = date,
                        Email = "X",
                        Instagram = "X",
                        Phone = "X",
                        Comments = "X",
                        PersonalID = 1
                    });
                context.SaveChanges();
            }
        }
    }
}
