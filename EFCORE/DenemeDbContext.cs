using Microsoft.EntityFrameworkCore;

namespace RazorPages.Deneme.EFCORE
{
    public class DenemeDbContext:DbContext
    {
        public DbSet<Hero> Heros { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Footer> Footer { get; set; }
        public DbSet<Whatsapp> Whatsapp { get; set; }
        public DbSet<AboutDetails> AboutDetails { get; set; }
        public DbSet<Users> Users { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = realMyDb.db");
        }
    }
}
