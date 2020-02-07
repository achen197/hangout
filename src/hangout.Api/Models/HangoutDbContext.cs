using Microsoft.EntityFrameworkCore;

namespace hangout.Domain
{
    public class HangoutDbContext : DbContext
    {
        public HangoutDbContext() {}
        
        public HangoutDbContext(DbContextOptions<HangoutDbContext> options) : base(options) {}
        
        public DbSet<Organiser> Organiser { get; set; }
    }
}