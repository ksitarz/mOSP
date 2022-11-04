using AutoMapper;
using Moq;
using mOSP.Application.Contracts.Persistence;
using mOSP.Application.Functions.MedKits.Commands;
using mOSP.Application.Mapper;
using mOSP.Application.UnitTest.Mocks;
using mOSP.Domain.Common;
using Shouldly;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace mOSP.Application.UnitTest.MedKits.Commands
{
    public class CreateMedKitTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IMedKitRepository> _mockMedKitRepository;

        public CreateMedKitTest()
        {
            _mockMedKitRepository = RepositoryMocks.GetMedKitRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            }
            );

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidMedKit_AddedToRepo()
        {
            var handler = new CreatedMedKitCommandHandler(_mockMedKitRepository.Object, _mapper);

            var allMedKitsBeforeCount = (await _mockMedKitRepository.Object.GetAllAsync()).Count;


            var command = new CreatedMedKitCommand()
            {
                Name = "Kit6",
                CreatedDate = DateTime.Now,
                OspId = 1,
                ContainerType = ContainerTypes.MedicalKit,
            };

            var response = await handler.Handle(command, CancellationToken.None);

            var allMedItems = await _mockMedKitRepository.Object.GetAllAsync();

            response.Success.ShouldBe(true);
            response.ValidationErrors.Count.ShouldBe(0);
            allMedItems.Count.ShouldBe(allMedKitsBeforeCount + 1);
            response.ContainerId.ShouldNotBeNull();
        }

        [Fact]
        public async Task Handle_ValidMedKitEmptyName_NotAddedToPostRepo()
        {
            var handler = new CreatedMedKitCommandHandler(_mockMedKitRepository.Object, _mapper);

            var allMedKitsBeforeCount = (await _mockMedKitRepository.Object.GetAllAsync()).Count;

            var command = new CreatedMedKitCommand()
            {
                Name = "",
                CreatedDate = DateTime.Now,
                OspId = 1,
                ContainerType = ContainerTypes.MedicalKit,
            };

            var response = await handler.Handle(command, CancellationToken.None);

            var allMedItems = await _mockMedKitRepository.Object.GetAllAsync();

            response.Success.ShouldBe(false);
            response.ValidationErrors.Count.ShouldBe(1);
            allMedItems.Count.ShouldBe(allMedKitsBeforeCount);
            response.ContainerId.ShouldBeNull();
        }

        [Fact]
        public async Task Handle_ValidMedKitEmptyOspId_NotAddedToPostRepo()
        {
            var handler = new CreatedMedKitCommandHandler(_mockMedKitRepository.Object, _mapper);

            var allMedKitsBeforeCount = (await _mockMedKitRepository.Object.GetAllAsync()).Count;

            var command = new CreatedMedKitCommand()
            {
                Name = "Kit6",
                CreatedDate = DateTime.Now,
                ContainerType = ContainerTypes.MedicalKit,
            };

            var response = await handler.Handle(command, CancellationToken.None);

            var allMedItems = await _mockMedKitRepository.Object.GetAllAsync();

            response.Success.ShouldBe(false);
            response.ValidationErrors.Count.ShouldBe(1);
            allMedItems.Count.ShouldBe(allMedKitsBeforeCount);
            response.ContainerId.ShouldBeNull();
        }
    }
}
