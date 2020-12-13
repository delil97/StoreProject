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

        public async Task<User> GetUserWithAdress(int userId)
        {
            return await _unitOfWork.Users
                .GetWithAdressById(userId);
        }

        public async Task<User> GetUserByUserName(string username)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateUser(User UserToBeUpdated, User User)
        {
            UserToBeUpdated.FirstName = User.FirstName;
            UserToBeUpdated.LastName = User.LastName;
            UserToBeUpdated.Adress = User.Adress;

            await _unitOfWork.CommitAsync();
        }
    }
}
