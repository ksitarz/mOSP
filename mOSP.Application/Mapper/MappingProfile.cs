using AutoMapper;
using mOSP.Application.Functions.MedItems;
using mOSP.Application.Functions.MedItems.Commands;
using mOSP.Application.Functions.MedKits;
using mOSP.Application.Functions.MedKits.Commands;
using mOSP.Domain.Entities;

namespace mOSP.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MedItem, MedItemViewModel>().ReverseMap();
            CreateMap<MedKit, MedItemDto>();
            CreateMap<MedItem, CreatedMedItemCommand>().ReverseMap();
            CreateMap<MedItem, UpdateMedItemCommand>().ReverseMap();
            CreateMap<MedKit, CreatedMedKitCommand>().ReverseMap();
            CreateMap<MedKit, UpdateMedKitCommand>().ReverseMap();
        }
    }
}
