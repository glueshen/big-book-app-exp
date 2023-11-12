using Microsoft.EntityFrameworkCore;
using BigBookApp.Models;

namespace BigBookApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Category> Categories { get; set;}
    }
}
