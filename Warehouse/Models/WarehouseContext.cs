using Microsoft.EntityFrameworkCore;

namespace Warehouse.Models
{
    public class WarehouseContext : DbContext
    {
        public DbSet<AProject> Projects { get; set; }
        public DbSet<ResearchFundingProject> ResearchFundingProjectsType { get; set; }
        public DbSet<RequestFundingProject> RequestFundingProjects { get; set; }
        public DbSet<Subproject> Subprojects { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Institute> Institutes { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Debitor> Debitors { get; set; }
        public DbSet<Funding> Fundings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subproject>()
                .HasOne(s => s.Project)
                .WithMany();

            modelBuilder.Entity<Facility>()
                .HasDiscriminator<string>("FACILITY_TYPE")
                .HasValue<Institute>("INSTITUTE")
                .HasValue<Facility>("FACILITY");

            modelBuilder.Entity<Subproject>()
                .HasOne(s => s.Institute)
                .WithMany();

            modelBuilder.Entity<Funding>()
                .HasKey(f => new {f.DebitorId, f.ProjectId});

            modelBuilder.Entity<Funding>()
                .HasOne(f => f.Project)
                .WithMany()
                .HasForeignKey(f => f.ProjectId);

            modelBuilder.Entity<Funding>()
                .HasOne(f => f.Debitor)
                .WithMany()
                .HasForeignKey(f => f.DebitorId);
        }

        public WarehouseContext(DbContextOptions<WarehouseContext> options) : base(options)
        {
            
        }
    }
}