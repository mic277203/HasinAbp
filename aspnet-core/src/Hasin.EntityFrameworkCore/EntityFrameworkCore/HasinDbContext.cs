using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Hasin.Authorization.Roles;
using Hasin.Authorization.Users;
using Hasin.MultiTenancy;
using System.Data;
using Hasin.Categorys;
using Hasin.Products;

namespace Hasin.EntityFrameworkCore
{
    public class HasinDbContext : AbpZeroDbContext<Tenant, Role, User, HasinDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public HasinDbContext(DbContextOptions<HasinDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categorys { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
