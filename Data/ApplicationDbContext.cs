using Microsoft.EntityFrameworkCore;

using ArrestTracker.Models;

namespace ArrestTracker.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Officers> Officers { get; set; }
    }
}
