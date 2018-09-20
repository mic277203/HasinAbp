using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Hasin.Configuration;
using Hasin.Web;

namespace Hasin.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HasinDbContextFactory : IDesignTimeDbContextFactory<HasinDbContext>
    {
        public HasinDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HasinDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HasinDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HasinConsts.ConnectionStringName));

            return new HasinDbContext(builder.Options);
        }
    }
}
