using AutoMapper;
using MediatR;
using mOSP.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.MedItems.Commands
{
    public class DeleteMedItemCommandHandler : IRequestHandler<DeleteMedItemCommand>
    {
        private readonly IMedItemRepository _medItemRepository;
        private readonly IMapper _mapper;

        public DeleteMedItemCommandHandler(IMedItemRepository medItemRepository, IMapper mapper)
        {
            _medItemRepository = medItemRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteMedItemCommand request, CancellationToken cancellationToken)
        {
            var itemToDelete = await _medItemRepository.GetByIdAsync(request.ItemId);
            await _medItemRepository.DeleteAsync(itemToDelete);
            
            return Unit.Value;
        }
    }
}
