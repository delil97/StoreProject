using Microsoft.EntityFrameworkCore;
using MyStore.Core.Models;
using MyStore.Core.Repositories;
using System.Linq;
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

        public Task<User> GetWithAdressById(string username, string password)
        {
            return MyStoreDbContext.Users.Include(a => a.Adress).Where(user => user.UserName == username && user.Password == password).SingleOrDefaultAsync();
               
        }

    }
}
