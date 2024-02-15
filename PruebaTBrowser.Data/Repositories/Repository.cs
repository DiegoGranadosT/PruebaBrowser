using PruebaTBrowser.Data.Repositories.Persistence.Repositories;
using PruebaTBrowser.Models.Base;

namespace PruebaTBrowser.Data.Repositories
{
    public class Repository<T, TId> : RepositoryWithTypedId<T, TId>, IRepository<T, TId>
        where T : class, IEntityWithTypedId<TId>
    {
        public Repository(PruebaDbContext context) : base(context)
        {

        }
    }
}
