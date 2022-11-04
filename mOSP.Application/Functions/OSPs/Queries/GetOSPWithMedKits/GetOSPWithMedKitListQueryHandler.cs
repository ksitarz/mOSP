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
    public class GetOSPWithMedKitListQueryHandler : IRequestHandler<GetOSPWithMedKitListQuery, List<OSPWithMedKitsViewModel>>
    {
        private readonly IOspRepository _ospRepository;
        private readonly IMapper _mapper;

        public GetOSPWithMedKitListQueryHandler(IOspRepository ospRepository, IMapper mapper)
        {
            _ospRepository = ospRepository;
            _mapper = mapper;
        }

        public async Task<List<OSPWithMedKitsViewModel>> Handle(GetOSPWithMedKitListQuery request, CancellationToken cancellationToken)
        {
            var list = await _ospRepository.GetOspWithMedKit();
            return _mapper.Map<List<OSPWithMedKitsViewModel>>(list);
        }
    }
}
