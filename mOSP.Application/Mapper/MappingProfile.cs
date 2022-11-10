using AutoMapper;
using mOSP.Application.Functions.MedItems;
using mOSP.Application.Functions.MedItems.Commands;
using mOSP.Application.Functions.MedKits;
using mOSP.Application.Functions.MedKits.Commands;
using mOSP.Application.Functions.OSPs.Commands;
using mOSP.Application.Functions.OSPs.Queries;
using mOSP.Domain.Entities;

namespace mOSP.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MedItem, MedItemViewModel>().ReverseMap();
            CreateMap<MedItem, CreatedMedItemCommand>().ReverseMap();
            CreateMap<MedItem, UpdateMedItemCommand>().ReverseMap();
            CreateMap<MedItem, MedItemDto>().ReverseMap();

            CreateMap<MedKit, MedKitViewModel>().ReverseMap();
            CreateMap<MedKit, CreatedMedKitCommand>().ReverseMap();
            CreateMap<MedKit, UpdateMedKitCommand>().ReverseMap();
            
            CreateMap<OSP, CreatedOSPCommand>().ReverseMap();
            CreateMap<OSP, UpdateOSPCommand>().ReverseMap();
            CreateMap<OSP, OSPWithMedKitsViewModel>().ReverseMap();

        }
    }
}
