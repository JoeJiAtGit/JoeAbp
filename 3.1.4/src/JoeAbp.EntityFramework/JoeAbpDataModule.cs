using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using JoeAbp.EntityFramework;

namespace JoeAbp
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(JoeAbpCoreModule))]
    public class JoeAbpDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<JoeAbpDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
