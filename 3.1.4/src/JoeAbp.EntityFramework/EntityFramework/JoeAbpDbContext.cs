using System.Data.Common;
using Abp.Zero.EntityFramework;
using JoeAbp.Authorization.Roles;
using JoeAbp.Authorization.Users;
using JoeAbp.MultiTenancy;

namespace JoeAbp.EntityFramework
{
    public class JoeAbpDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public JoeAbpDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in JoeAbpDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of JoeAbpDbContext since ABP automatically handles it.
         */
        public JoeAbpDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public JoeAbpDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public JoeAbpDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
