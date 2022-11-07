using AutoMapper;
using MediatR;
using mOSP.Application.Contracts.Persistence;
using mOSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.MedKits.Queries
{
    public class GetMedKitWithItemListQueryHandler : IRequestHandler<GetMedKitWithItemListQuery, List<MedKitViewModel>>
    {
        private readonly IMedKitRepository _medKitRepository;
        private readonly IMapper _mapper;

        public GetMedKitWithItemListQueryHandler(IMapper mapper, IMedKitRepository medKitRepository)
        {
            _mapper = mapper;
            _medKitRepository = medKitRepository;
        }

        public async Task<List<MedKitViewModel>> Handle(GetMedKitWithItemListQuery request, CancellationToken cancellationToken)
        {
            var list = await _medKitRepository.GetMedKitWithItem(request.ContainerId, request.SearchOptions);
            return _mapper.Map<List<MedKitViewModel>>(list);

        }
    }
}
