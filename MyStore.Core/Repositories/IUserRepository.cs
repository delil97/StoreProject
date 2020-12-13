using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyStore.Core.Models;

namespace MyStore.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetWithAdressById(string username, string password);

    }
}
