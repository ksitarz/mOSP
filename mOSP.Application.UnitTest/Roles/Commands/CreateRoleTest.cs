using AutoMapper;
using Moq;
using mOSP.Application.Contracts.Persistence;
using mOSP.Application.Functions.MedKits.Commands;
using mOSP.Application.Functions.Roles.Commands;
using mOSP.Application.Mapper;
using mOSP.Application.UnitTest.Mocks;
using mOSP.Domain.Common;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace mOSP.Application.UnitTest.Roles.Commands
{
    public class CreateRoleTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IRoleRepository> _mockRoleRepository;

        public CreateRoleTest()
        {
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            }
            );

            _mapper = configurationProvider.CreateMapper();
            _mockRoleRepository = RepositoryMocks.GetRoleRepository();
        }

        [Fact]
        public async Task Handle_ValidRole_AddedToRepo()
        {
            var handler = new CreatedRoleCommandHandler(_mockRoleRepository.Object, _mapper);

            var allRolesBeforeCount = (await _mockRoleRepository.Object.GetAllAsync()).Count;


            var command = new CreatedRoleCommand()
            {
                RoleId = 3,
                Name = "Janusz"
            };

            var response = await handler.Handle(command, CancellationToken.None);

            var allRoles = await _mockRoleRepository.Object.GetAllAsync();

            response.Success.ShouldBe(true);
            response.ValidationErrors.Count.ShouldBe(0);
            allRoles.Count.ShouldBe(allRolesBeforeCount + 1);
            response.RoleId.ShouldNotBeNull();
        }
        [Fact]
        public async Task Handle_ValidRoleEmptyName_NotAddedToRepo()
        {
            var handler = new CreatedRoleCommandHandler(_mockRoleRepository.Object, _mapper);

            var allRolesBeforeCount = (await _mockRoleRepository.Object.GetAllAsync()).Count;


            var command = new CreatedRoleCommand()
            {
                RoleId = 3,
                Name = ""
            };

            var response = await handler.Handle(command, CancellationToken.None);

            var allRoles = await _mockRoleRepository.Object.GetAllAsync();

            response.Success.ShouldBe(false);
            response.ValidationErrors.Count.ShouldBe(1);
            allRoles.Count.ShouldBe(allRolesBeforeCount);
            response.RoleId.ShouldBeNull();
        }
       
    }
}
