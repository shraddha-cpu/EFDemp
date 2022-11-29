using Microsoft.EntityFrameworkCore;

namespace EFDemp.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            :base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
