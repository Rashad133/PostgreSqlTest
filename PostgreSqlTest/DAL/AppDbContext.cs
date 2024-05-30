using Microsoft.EntityFrameworkCore;
using PostgreSqlTest.Model;


namespace PostgreSqlTest.DAL
{
    public class AppDbContext:DbContext
    {
        private readonly IConfiguration _configuration;
        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration; 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("TestDB"));
        }

        public DbSet<Product> Products { get; set; }    
    }
}
