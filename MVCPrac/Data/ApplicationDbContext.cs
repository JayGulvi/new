using Microsoft.EntityFrameworkCore;
using MVCPrac.Models;

namespace MVCPrac.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }
        public DbSet<Vehicles> Vehicles { get; set; }

    }
}
