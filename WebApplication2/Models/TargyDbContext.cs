using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class TargyDbContext :DbContext
    {
       
        public TargyDbContext() { }

        public TargyDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string conn = "server=localhost; database=Tantargyak; user=root; password=";

                optionsBuilder.UseMySQL(conn);
            }
        }

        public DbSet<Targy> NewTargy { get; set; } = null!;
    }
}
