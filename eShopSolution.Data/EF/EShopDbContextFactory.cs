using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace eShopSolution.Data.EF;

public class EShopDbContextFactory : IDesignTimeDbContextFactory<EShopDbContext>
{
    public EShopDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        
        string? connectionString = configuration.GetConnectionString("eShopSolutionDb");
        Console.WriteLine(connectionString);
        var optionsBuilder = new DbContextOptionsBuilder<EShopDbContext>();
        optionsBuilder.UseSqlServer(connectionString);
        return new EShopDbContext(optionsBuilder.Options);
    }
}