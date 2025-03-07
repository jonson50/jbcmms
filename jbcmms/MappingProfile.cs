using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace jbcmms
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Asset, AssetDto>();
        }
    }
}
