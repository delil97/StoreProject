using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyStore.Core;
using MyStore.Core.Models;
using MyStore.Core.Services;

namespace MyStore.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<User> CreateUser(User newUser)
        {
            await _unitOfWork.Users.AddAsync(newUser);
            await _unitOfWork.CommitAsync();
            return newUser;
        }

        public async Task DeleteUser(User User)
        {
            _unitOfWork.Users.Remove(User);
            await _unitOfWork.CommitAsync();
        }

        public async Task<User> GetUserWithAdress(string username, string password)
        {
            var user = await _unitOfWork.Users
                .GetWithAdressById(username, password);
            user.Adress = null;
            return user;
        }

        public async Task<User> GetUserByUserName(string username)
        {
            return await _unitOfWork.Users.SingleOrDefaultAsync(x => x.UserName == username);

        }

        public async Task UpdateUser(User UserToBeUpdated, User User)
        {
            //TODO: Debugga hela skiten sen
            UserToBeUpdated.FirstName = User.FirstName; // UserToBeUpdated finns i databasen
            UserToBeUpdated.LastName = User.LastName;
            await _unitOfWork.CommitAsync(); // kolla upp detta
        }

        public async Task<User> GetUserById(int id)
        {
            var user = await _unitOfWork.Users.GetByIdAsync(id);
            return user;
        }

        
    }
}
