using DB_993.Classes;
using Microsoft.EntityFrameworkCore;


namespace UnitTestRecommendationProject
{
    public class TestDBContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Realty> Realtys { get; set; } = null!;
        public DbSet<Recommendations> Recommendations { get; set; } = null!;
        public DbSet<Compilation> Compilations { get; set; } = null!;
        public DbSet<BlackListTable> BlackLists { get; set; } = null!;
        public DbSet<Favourites> Favourites { get; set; } = null!;

        public void ApplicationContext()
        {
            Database.EnsureCreated();
            Database.OpenConnection();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ProectDB2.db");
        }
    }
}
