using Microsoft.EntityFrameworkCore;
using OgrenciBilgiSistemi.Models;

namespace OgrenciBilgiSistemi.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; database=OgrenciBilgiSistemi; trusted_connection=true;");
            // add-migration InitialCreate : bu komut veritabanı oluşturacak olan tablo yapısını oluşturur
            // update-database : bu komut oluşan migrationdaki tablo yapısını veritabanına işler
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    Name = "Ali",
                    Surname = "Cambaz",
                    Address = "Ataşehir",
                    City = "İstanbul",
                    Email = "ali@cambaz.net",
                    Phone = "0216 444 55 66"
                },
                new Student
                {
                    Id = 2,
                    Name = "Alp",
                    Surname = "Arslan",
                    Address = "Ataşehir",
                    City = "İstanbul",
                    Email = "alp@gmail.net",
                    Phone = "0218 444 55 66"
                },
                new Student
                {
                    Id = 3,
                    Name = "Murat",
                    Surname = "Yılmaz",
                    Address = "Atalar",
                    City = "Kartal",
                    Email = "murat@cambaz.net",
                    Phone = "0543 444 55 66"
                }
                );
            //List<Student> studentList = FakeData.FakeDatas.GenerateStudent(20);
            //dbContext.Students.AddRange(studentList);
            //await dbContext.SaveChangesAsync();
            base.OnModelCreating(modelBuilder);
        }
    }
}
