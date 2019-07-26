using Microsoft.EntityFrameworkCore;
using SuperHeroCreator.Models;

namespace SuperHeroCreator.Services
{
    public class SuperHeroesDbContext : DbContext
    {
        public DbSet<SuperHero> SuperHeroes { get; set; }
        public SuperHeroesDbContext(DbContextOptions<SuperHeroesDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Server=localhost;Database=SuperHeroesDb;User Id=sa;Password=Passw0rd**");
                return;
            }
        }
    }
}