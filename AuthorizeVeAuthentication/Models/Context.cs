using Microsoft.EntityFrameworkCore;

namespace AuthorizeVeAuthentication.Models
{
    public class Context:DbContext
    {
        public DbSet<TbKullanici> Kullanicilar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=dbKullanici;Trusted_Connection=True;");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbKullanici>().HasData(
                new TbKullanici() { id = 1, ad = "Kullanıcı1", soyad = "Kullanıcı1", email = "kullanici1@gmail.com", role = "Yönetici", sifre = "kullanici1" },
                new TbKullanici() { id = 2, ad = "Kullanıcı2", soyad = "Kullanıcı2", email = "kullanici2@gmail.com", role = "Admin", sifre = "kullanici2" },
                new TbKullanici() { id = 3, ad = "Kullanıcı3", soyad = "Kullanıcı3", email = "kullanici3@gmail.com", role = "Üye", sifre = "kullanici3" },
                new TbKullanici() { id = 4, ad = "Kullanıcı4", soyad = "Kullanıcı4", email = "kullanici4@gmail.com", role = "Ban", sifre = "kullanici4" }
                );
        }
    }
}
