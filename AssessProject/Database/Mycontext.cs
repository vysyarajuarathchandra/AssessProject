using AssessProject.Entites;
using Microsoft.EntityFrameworkCore;

namespace AssessProject.Database
{
    public class Mycontext : DbContext
    {
        public DbSet<Book>Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = KOMAL; Initial Catalog=Book23;User Id=Ecom;Password=1234;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
