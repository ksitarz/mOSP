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

namespace mOSP.Application.Functions.MedItems.Commands
{
    public class CreatedMedItemCommandHandler : IRequestHandler<CreatedMedItemCommand, CreatedMedItemCommandResponse>
    {
        private readonly IMedItemRepository _medItemRepository;
        private readonly IMapper _mapper;

        public CreatedMedItemCommandHandler(IMedItemRepository medItemRepository, IMapper mapper)
        {
            _medItemRepository = medItemRepository;
            _mapper = mapper;
        }

        public async Task<CreatedMedItemCommandResponse> Handle(CreatedMedItemCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreatedMedItemCommandValidator();
            var validatorResult = await validator.ValidateAsync(request);

            if (!validatorResult.IsValid)
                return new CreatedMedItemCommandResponse(validatorResult);

            var medItem = _mapper.Map<MedItem>(request);

            medItem = await _medItemRepository.AddAsync(medItem);

            return new CreatedMedItemCommandResponse(medItem.ItemId);
        }
    }
}
