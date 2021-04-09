using Microsoft.EntityFrameworkCore;

namespace $safeprojectname$
{
    public sealed class ApplicationDbContext : DbContext
    {
        //public DbSet<YOUR_ENTITY> YOUR_ENTITY_NAME { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
