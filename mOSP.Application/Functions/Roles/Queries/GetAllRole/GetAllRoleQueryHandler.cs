using AutoMapper;
using MediatR;
using mOSP.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.Roles.Queries
{
    public class GetAllRoleQueryHandler : IRequestHandler<GetAllRoleQuery, List<RoleViewModel>>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public GetAllRoleQueryHandler(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<List<RoleViewModel>> Handle(GetAllRoleQuery request, CancellationToken cancellationToken)
        {
            var role = await _roleRepository.GetAllAsync();
            var roleMaped = _mapper.Map<List<RoleViewModel>>(role);

            return roleMaped;
        }
    }
}
