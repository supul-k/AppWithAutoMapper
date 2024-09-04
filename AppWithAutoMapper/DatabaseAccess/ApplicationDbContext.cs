using AppWithAutoMapper.Models;
using Microsoft.EntityFrameworkCore;

namespace AppWithAutoMapper.DatabaseAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { } 

        public DbSet<User> Users { get; set; }
    }
}
