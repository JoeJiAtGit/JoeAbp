using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using JoeAbp.EntityFramework;

namespace JoeAbp.Migrator
{
    [DependsOn(typeof(JoeAbpDataModule))]
    public class JoeAbpMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<JoeAbpDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}