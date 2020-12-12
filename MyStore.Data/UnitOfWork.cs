using MyStore.Core;
using MyStore.Core.Repositories;
using MyStore.Data.Repositories;
using System.Threading.Tasks;

namespace MyStore.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyStoreDbContext _context;
        private UserRepository _musicRepository;
        private AdressRepository _artistRepository;

        public UnitOfWork(MyStoreDbContext context)
        {
            this._context = context;
        }

        public IUserRepository Users => _musicRepository = _musicRepository ?? new UserRepository(_context);

        public IAdressRepository Adresses => _artistRepository = _artistRepository ?? new AdressRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
