using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using JoeAbp.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace JoeAbp.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<JoeAbp.EntityFramework.JoeAbpDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "JoeAbp";
        }

        protected override void Seed(JoeAbp.EntityFramework.JoeAbpDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
