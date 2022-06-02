using System.Data.Entity;

namespace Solicitor.Models
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
       
        public DbSet<News> News { get; set; }
       
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SubService> ServiceDetails { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Claim
            modelBuilder
                .Entity<Claim>()
                .MapToStoredProcedures(s =>
                {
                    s.Insert(i => i.HasName("Insert_Claims_SP")
                                   .Parameter(p => p.Name, "Name")
                                   .Parameter(p => p.Email, "Email")
                                   .Parameter(p => p.ContactNo, "ContactNo")
                                   .Parameter(p => p.Detail, "Detail")
                                   .Parameter(p => p.Date, "Date")
                    );

                    s.Update(i => i.HasName("Update_Claims_SP")
                                   .Parameter(p => p.ClaimID, "ClaimID")
                                   .Parameter(p => p.Name, "Name")
                                   .Parameter(p => p.Email, "Email")
                                   .Parameter(p => p.ContactNo, "ContactNo")
                                   .Parameter(p => p.Detail, "Detail")
                                   .Parameter(p => p.Date, "Date")
                    );

                    s.Delete(d => d.HasName("Delete_Claims_SP")
                                 .Parameter(p => p.ClaimID, "ClaimID")
                    );

                });


            //Services
           


        }
    }
}