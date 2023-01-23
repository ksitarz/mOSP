using AutoMapper;
using MediatR;
using mOSP.Application.Contracts.Persistence;
using mOSP.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.Roles.Commands
{
    public class CreatedRoleCommandHandler : IRequestHandler<CreatedRoleCommand, CreatedRoleCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IRoleRepository _roleRepository;

        public CreatedRoleCommandHandler(IRoleRepository roleRepository, IMapper mapper) 
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }
        public async Task<CreatedRoleCommandResponse> Handle(CreatedRoleCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreatedRoleCommandValidator();
            var validatorResult = await validator.ValidateAsync(request);

            if (!validatorResult.IsValid)
                return new CreatedRoleCommandResponse(validatorResult);

            var role = _mapper.Map<Role>(request);

            role = await _roleRepository.AddAsync(role);

            return new CreatedRoleCommandResponse(role.RoleId);
        }
    }
}

