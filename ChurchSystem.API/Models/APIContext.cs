using Microsoft.EntityFrameworkCore;

namespace ChurchSystem.API.Models

{

    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) { }

        public DbSet<Youths> Youths { get; set; }
        public DbSet<Children> Children { get; set; }
        public DbSet<Tithe> Tithe { get; set; }
    }
}