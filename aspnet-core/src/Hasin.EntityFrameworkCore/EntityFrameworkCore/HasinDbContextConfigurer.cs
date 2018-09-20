using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Hasin.EntityFrameworkCore
{
    public static class HasinDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HasinDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString, b => b.UseRowNumberForPaging());
        }

        public static void Configure(DbContextOptionsBuilder<HasinDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection, b => b.UseRowNumberForPaging());
        }
    }
}
