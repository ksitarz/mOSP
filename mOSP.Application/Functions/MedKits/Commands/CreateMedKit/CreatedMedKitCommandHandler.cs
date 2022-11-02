using AutoMapper;
using MediatR;
using mOSP.Application.Contracts.Persistence;
using mOSP.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.MedKits.Commands
{
    public class CreatedMedKitCommandHandler : IRequestHandler<CreatedMedKitCommand, CreatedMedKitCommandResponse>
    {
        private readonly IMedKitRepository _medKitRepository;
        private readonly IMapper _mapper;

        public CreatedMedKitCommandHandler(IMedKitRepository medKitRepository, IMapper mapper)
        {
            _medKitRepository = medKitRepository;
            _mapper = mapper;
        }

        public async Task<CreatedMedKitCommandResponse> Handle(CreatedMedKitCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreatedMedKitCommandValidator();
            var validatorResult = await validator.ValidateAsync(request);

            if(!validatorResult.IsValid)
                return new CreatedMedKitCommandResponse(validatorResult);

            var medKit = _mapper.Map<MedKit>(request);

            medKit = await _medKitRepository.AddAsync(medKit);

            return new CreatedMedKitCommandResponse(medKit.ContainerId);
        }
    }
}
