using MyStore.Core.Models;
using MyStore.Core.Repositories;

namespace MyStore.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(MyStoreDbContext context)
            : base(context)
        { }

        private MyStoreDbContext MyStoreDbContext
        {
            get { return Context as MyStoreDbContext; }
        }
    }
}
