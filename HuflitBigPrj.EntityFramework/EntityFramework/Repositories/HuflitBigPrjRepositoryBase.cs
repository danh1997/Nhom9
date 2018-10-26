using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace HuflitBigPrj.EntityFramework.Repositories
{
    public abstract class HuflitBigPrjRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<HuflitBigPrjDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected HuflitBigPrjRepositoryBase(IDbContextProvider<HuflitBigPrjDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class HuflitBigPrjRepositoryBase<TEntity> : HuflitBigPrjRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected HuflitBigPrjRepositoryBase(IDbContextProvider<HuflitBigPrjDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
