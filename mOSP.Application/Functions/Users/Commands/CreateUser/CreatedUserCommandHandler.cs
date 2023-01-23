using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using mOSP.Application.Contracts.Persistence;
using mOSP.Application.Functions.Roles.Commands;
using mOSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.Users.Commands
{
    public class CreatedUserCommandHandler : IRequestHandler<CreatedUserCommand, CreatedUserCommandResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IPasswordHasher<User> _passwordHasher;

        public CreatedUserCommandHandler(IUserRepository userRepository, IMapper mapper, IPasswordHasher<User> passwordHasher)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _passwordHasher = passwordHasher;

        }

        public async Task<CreatedUserCommandResponse> Handle(CreatedUserCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreatedUserCommandValidator();
            var validatorResult = await validator.ValidateAsync(request);

            if (!validatorResult.IsValid)
                return new CreatedUserCommandResponse(validatorResult);

            var newUser = new User()
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                RoleId = request.RoleId

            };
            var hashedPassword = _passwordHasher.HashPassword(newUser, request.Password);

            newUser.PasswordHash = hashedPassword;

            newUser = await _userRepository.AddAsync(newUser);

            return new CreatedUserCommandResponse(newUser.UserId);
        }
    }
}
