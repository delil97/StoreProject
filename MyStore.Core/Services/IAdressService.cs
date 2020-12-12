using MyStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Core.Services
{
    interface IAdressService
    {
        Task<Adress> CreateAdress(Adress newAdress);
    }
}
