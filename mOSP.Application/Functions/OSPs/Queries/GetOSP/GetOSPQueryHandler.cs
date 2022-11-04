using AutoMapper;
using MediatR;
using mOSP.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.OSPs.Queries.GetOSP
{
    public class GetOSPQueryHandler : IRequestHandler<GetOSPQuery, OSPViewModel>
    {
        private readonly IOspRepository _ospRepository;
        private readonly IMapper _mapper;

        public GetOSPQueryHandler(IOspRepository ospRepository, IMapper mapper)
        {
            _ospRepository = ospRepository;
            _mapper = mapper;
        }

        public async Task<OSPViewModel> Handle(GetOSPQuery request, CancellationToken cancellationToken)
        {
            var osp = await _ospRepository.GetByIdAsync(request.OspId);
            var ospMaped = _mapper.Map<OSPViewModel>(osp);

            return ospMaped; 
        }
    }
}
