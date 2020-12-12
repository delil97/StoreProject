using AutoMapper;
using MyStore.API.Resources;
using MyStore.Core.Models;

namespace MyStore.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserResources>();
            CreateMap<Adress, AdressResources>();

            CreateMap<UserResources, User>();
            CreateMap<AdressResources, Adress>();
        }
    }
}
