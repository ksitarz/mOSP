using AutoMapper;
using MediatR;
using mOSP.Application.Contracts.Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.Roles.Commands
{
    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public DeleteRoleCommandHandler(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            var roleToDelete = await _roleRepository.GetByIdAsync(request.RoleId);

            await _roleRepository.DeleteAsync(roleToDelete);

            return Unit.Value;
        }
    }
}
