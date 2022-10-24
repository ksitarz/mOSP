using AutoMapper;
using MediatR;
using mOSP.Application.Contracts.Persistence;
using mOSP.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.MedItems
{
    public class GetMedItemByContainerQueryHandler : IRequestHandler<GetMedItemByContainerQuery, List<MedItemViewModel>>
    {
        private readonly IAsyncRepository<MedItem> _medItemRepository;
        private readonly IMapper _mapper;

        public GetMedItemByContainerQueryHandler(IMapper mapper, IAsyncRepository<MedItem> medItemRepository)
        {
            _mapper = mapper;
            _medItemRepository = medItemRepository;
        }

        public async Task<List<MedItemViewModel>> Handle(GetMedItemByContainerQuery request, CancellationToken cancellationToken)
        {
            var all = await _medItemRepository.GetAllAsync();

            return _mapper.Map<List<MedItemViewModel>>(all);
        }
    }
}
