using AutoMapper;
using MediatR;
using mOSP.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.OSPs.Queries
{
    public class GetOSPWithContainersListQueryHandler : IRequestHandler<GetOSPWithMedKitListQuery, List<OSPWithContainersViewModel>>
    {
        private readonly IOspRepository _ospRepository;
        private readonly IMapper _mapper;

        public GetOSPWithContainersListQueryHandler(IOspRepository ospRepository, IMapper mapper)
        {
            _ospRepository = ospRepository;
            _mapper = mapper;
        }

        public async Task<List<OSPWithContainersViewModel>> Handle(GetOSPWithMedKitListQuery request, CancellationToken cancellationToken)
        {
            var list = await _ospRepository.GetOspWithContainers(request.OspId);
            return _mapper.Map<List<OSPWithContainersViewModel>>(list);
        }
    }
}
