using MyStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Core.Services
{
    public interface IAdressService
    {
        Task CreateAdress(Adress newAdress);
    }
}
