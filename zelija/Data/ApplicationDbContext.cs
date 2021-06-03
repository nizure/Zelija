using zelija.Models;
using Microsoft.EntityFrameworkCore;

namespace zelija.Data

{

    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }
        public DbSet<Category> Category {get; set; }

    }
}