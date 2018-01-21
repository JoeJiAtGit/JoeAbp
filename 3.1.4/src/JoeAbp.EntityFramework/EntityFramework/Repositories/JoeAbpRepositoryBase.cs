using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace JoeAbp.EntityFramework.Repositories
{
    public abstract class JoeAbpRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<JoeAbpDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected JoeAbpRepositoryBase(IDbContextProvider<JoeAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class JoeAbpRepositoryBase<TEntity> : JoeAbpRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected JoeAbpRepositoryBase(IDbContextProvider<JoeAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
