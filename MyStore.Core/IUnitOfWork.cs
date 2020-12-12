using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyStore.Core.Repositories;

namespace MyStore.Core
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }

        IAdressRepository Adress { get; }

        Task<int> CommitAsync();
    }
}
