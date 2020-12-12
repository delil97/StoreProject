using MyStore.Core;
using System;
using System.Collections.Generic;
using System.Text;

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

        public IUserRepository Musics => _musicRepository = _musicRepository ?? new MusicRepository(_context);

        public IAdressRepository Artists => _artistRepository = _artistRepository ?? new ArtistRepository(_context);

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
