using Microsoft.EntityFrameworkCore;

namespace Warehouse.Models
{
    public class WarehouseContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<ResearchFundingProject> ResearchFundingProjectsType { get; set; }
        public DbSet<RequestFundingProject> RequestFundingProjects { get; set; }
        public DbSet<Subproject> Subprojects { get; set; }
        public WarehouseContext(DbContextOptions<WarehouseContext> options) : base(options)
        {
            
        }
    }
}