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

        public IUserRepository Musics => _musicRepository = _musicRepository ?? new UserRepository(_context);

        public IAdressRepository Artists => _artistRepository = _artistRepository ?? new AdressRepository(_context);

        public IUserRepository User => throw new System.NotImplementedException();

        public IAdressRepository Adress => throw new System.NotImplementedException();

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
