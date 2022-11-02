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
    public class CreatedOSPCommandHandler : IRequestHandler<CreatedOSPCommand, CreatedOSPCommandResponse>
    {
        private readonly IOspRepository _ospRepository;
        private readonly IMapper _mapper;

        public CreatedOSPCommandHandler(IOspRepository ospRepository, IMapper mapper)
        {
            _ospRepository = ospRepository;
            _mapper = mapper;
        }

        public async Task<CreatedOSPCommandResponse> Handle(CreatedOSPCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreatedOSPCommandValidator();
            var validatorResult = await validator.ValidateAsync(request);

            if (!validatorResult.IsValid)
                return new CreatedOSPCommandResponse(validatorResult);
            
            var osp = _mapper.Map<OSP>(request);

            osp = await _ospRepository.AddAsync(osp);

            return new CreatedOSPCommandResponse(osp.OspId);
        }
    }
}
