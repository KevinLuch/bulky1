using Microsoft.EntityFrameworkCore;
using MvcBulkyBook.Models;

namespace MvcBulkyBook.Data
{
    public class ApplicationDbContext :DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
