using AutoMapper;
using MediatR;
using mOSP.Application.Contracts.Persistence;
using mOSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.OSPs.Commands
{
    public class UpdateOSPCommandHandler : IRequestHandler<UpdateOSPCommand>
    {
        private readonly IOspRepository _ospRepository;
        private readonly IMapper _mapper;

        public UpdateOSPCommandHandler(IOspRepository ospRepository, IMapper mapper)
        {
            _ospRepository = ospRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateOSPCommand request, CancellationToken cancellationToken)
        {
            var osp = _mapper.Map<OSP>(request);

            await _ospRepository.UpdateAsync(osp);

            return Unit.Value;
        }
    }
}
