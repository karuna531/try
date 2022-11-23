using Microsoft.EntityFrameworkCore;
using Supreme.Models;

namespace Supreme.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }
        public DbSet<Category> Categories { get; set; }
    }
}
