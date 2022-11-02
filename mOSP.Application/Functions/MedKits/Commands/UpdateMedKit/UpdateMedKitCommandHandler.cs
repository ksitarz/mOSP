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

namespace mOSP.Application.Functions.MedKits.Commands
{
    public class UpdateMedKitCommandHandler : IRequestHandler<UpdateMedKitCommand>
    {
        private readonly IMedKitRepository _medKitRepository;
        private readonly IMapper _mapper;

        public UpdateMedKitCommandHandler(IMedKitRepository medKitRepository, IMapper mapper)
        {
            _medKitRepository = medKitRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateMedKitCommand request, CancellationToken cancellationToken)
        {
            var medKit = _mapper.Map<MedKit>(request);

            await _medKitRepository.UpdateAsync(medKit);

            return Unit.Value;
        }
    }
}
