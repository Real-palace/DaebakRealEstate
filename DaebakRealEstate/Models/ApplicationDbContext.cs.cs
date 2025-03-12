using Microsoft.EntityFrameworkCore;

namespace DaebakRealEstate.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<UserViewModel> Users { get; set; }
    }
}
