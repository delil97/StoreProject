using System;
using System.Collections.Generic;
using System.Text;
using MyStore.Core.Services;
using MyStore.Core.Models;
using System.Threading.Tasks;
using MyStore.Core;

namespace MyStore.Services
{
    public class AdressService : IAdressService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AdressService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<Adress> CreateAdress(Adress newAdress)
        {
            await _unitOfWork.Adresses.AddAsync(newAdress);

            return newAdress;
        }
    }
}
