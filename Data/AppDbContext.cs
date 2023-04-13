using Microsoft.EntityFrameworkCore;
using SampleMediatR.Entity;

namespace SampleMediatR.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
