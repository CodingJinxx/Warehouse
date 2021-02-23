using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Warehouse.Models
{
    public class WarehouseContextFactory : IDesignTimeDbContextFactory<WarehouseContext>
    {
        public WarehouseContext CreateDbContext(string[] args)
        {
            var properties = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var optionsbuilder = new DbContextOptionsBuilder<WarehouseContext>();

            optionsbuilder
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                .UseMySql(properties["ConnectionStrings:DefaultConnection"], ServerVersion.FromString("8.0.23"), null);
            
            return new WarehouseContext(optionsbuilder.Options);
        }
    }
}