using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyStore.Core.Models;
using MyStore.Core.Repositories;

namespace MyStore.Data.Repositories
{
    public class AdressRepository : Repository<Adress>, IAdressRepository
    {
        public AdressRepository(MyStoreDbContext context)
            : base(context)
        { }

        private MyStoreDbContext MyStoreDbContext
        {
            get { return Context as MyStoreDbContext; }
        }
    }
}
