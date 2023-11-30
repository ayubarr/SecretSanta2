using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SecretSantaApp
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder
                .UseSqlServer(connectionString);
        }
    }
}
