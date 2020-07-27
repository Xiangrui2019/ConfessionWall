using ConfessionWall.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConfessionWall.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Message> Messages { get; set; }
    }
}