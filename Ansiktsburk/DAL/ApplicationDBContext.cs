using Ansiktsburk.Models;
using Microsoft.EntityFrameworkCore;

namespace Ansiktsburk.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
