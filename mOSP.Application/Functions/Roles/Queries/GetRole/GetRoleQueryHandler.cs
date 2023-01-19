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
    public class GetRoleQueryHandler : IRequestHandler<GetRoleQuery, RoleViewModel>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public GetRoleQueryHandler(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<RoleViewModel> Handle(GetRoleQuery request, CancellationToken cancellationToken)
        {
            var role = await _roleRepository.GetByIdAsync(request.RoleID);
            var roleMaped = _mapper.Map<RoleViewModel>(role);

            return roleMaped;
        }
    }
}
