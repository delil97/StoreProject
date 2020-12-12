using Microsoft.EntityFrameworkCore;
using MyStore.Core.Models;
using MyStore.Core.Repositories;
using System.Threading.Tasks;

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

        public Task<User> GetWithAdressById(int id)
        {
            return MyStoreDbContext.Users.Include(a => a.Adress).SingleOrDefaultAsync(u => u.Id == id);
        }

    }
}
