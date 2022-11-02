using AutoMapper;
using MediatR;
using mOSP.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.MedKits.Commands
{
    public class DeleteMedKitCommandHandler : IRequestHandler<DeleteMedKitCommand>
    {
        private readonly IMedKitRepository _medKitRepository;
        private readonly IMapper _mapper;

        public DeleteMedKitCommandHandler(IMedKitRepository medKitRepository, IMapper mapper)
        {
            _medKitRepository = medKitRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteMedKitCommand request, CancellationToken cancellationToken)
        {
            var medKitToDelete = await _medKitRepository.GetByIdAsync(request.ContainerId);

            await _medKitRepository.DeleteAsync(medKitToDelete);

            return Unit.Value;
        }
    }
}
