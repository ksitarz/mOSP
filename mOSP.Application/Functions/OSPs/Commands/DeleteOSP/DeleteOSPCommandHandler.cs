using AutoMapper;
using MediatR;
using mOSP.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.OSPs.Commands
{
    public class DeleteOSPCommandHandler : IRequestHandler<DeleteOSPCommand>
    {
        private readonly IOspRepository _ospRepository;
        private readonly IMapper _mapper;

        public DeleteOSPCommandHandler(IOspRepository ospRepository, IMapper mapper)
        {
            _ospRepository = ospRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteOSPCommand request, CancellationToken cancellationToken)
        {
            var ospToDelete = await _ospRepository.GetByIdAsync(request.OspId);

            await _ospRepository.DeleteAsync(ospToDelete);

            return Unit.Value;
        }
    }
}
