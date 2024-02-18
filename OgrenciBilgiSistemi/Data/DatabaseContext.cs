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
    }
}
