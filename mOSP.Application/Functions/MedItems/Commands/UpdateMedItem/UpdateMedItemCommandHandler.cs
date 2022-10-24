using AutoMapper;
using MediatR;
using mOSP.Application.Contracts.Persistence;
using mOSP.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.MedItems.Commands
{
    public class UpdateMedItemCommandHandler : IRequestHandler<UpdateMedItemCommand>
    {
        private readonly IMedItemRepository _medItemRepository;
        private readonly IMapper _mapper;

        public UpdateMedItemCommandHandler(IMedItemRepository medItemRepository, IMapper mapper)
        {
            _medItemRepository = medItemRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateMedItemCommand request, CancellationToken cancellationToken)
        {
            var medItem = _mapper.Map<MedItem>(request);
            await _medItemRepository.UpdateAsync(medItem);

            return Unit.Value;
        }
    }
}
