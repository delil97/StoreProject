using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyStore.Core.Models;

namespace MyStore.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetWithAdressById(int id);

        Task UpdateUser(User userToBeUpdated, User user);

        Task DeleteUser(User user);
    }
}
