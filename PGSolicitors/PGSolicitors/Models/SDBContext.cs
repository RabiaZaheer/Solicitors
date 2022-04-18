using System.Data.Entity;

namespace PGSolicitors.Models
{
    public class SDBContext : DbContext
    {
        public SDBContext()
           : base("name=SCS")
        {
        }
        public DbSet<Status> Status { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SubService> ServiceDetails { get; set; }
        public DbSet<News> News { get; set; }

    }
}