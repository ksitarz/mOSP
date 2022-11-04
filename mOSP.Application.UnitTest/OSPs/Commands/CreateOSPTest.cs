using AutoMapper;
using Moq;
using mOSP.Application.Contracts.Persistence;
using mOSP.Application.Functions.OSPs.Commands;
using mOSP.Application.Mapper;
using mOSP.Application.UnitTest.Mocks;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace mOSP.Application.UnitTest.OSPs.Commands
{
    public class CreateOSPTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IOspRepository> _mockOspRepository;

        public CreateOSPTest()
        {
            _mockOspRepository = RepositoryMocks.GetOspRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            }
            );

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidOSP_AddedToRepo()
        {
            var handler = new CreatedOSPCommandHandler(_mockOspRepository.Object, _mapper);

            var allMedItemsBeforeCount = (await _mockOspRepository.Object.GetAllAsync()).Count;

            var command = new CreatedOSPCommand()
            {
                Name = "OSP3",
            };

            var response = await handler.Handle(command, CancellationToken.None);

            var allMedItems = await _mockOspRepository.Object.GetAllAsync();

            response.Success.ShouldBe(true);
            response.ValidationErrors.Count.ShouldBe(0);
            allMedItems.Count.ShouldBe(allMedItemsBeforeCount + 1);
            response.OspId.ShouldNotBeNull();
        }

        [Fact]
        public async Task Handle_ValidOSPEmptyName_NotAddedToPostRepo()
        {
            var handler = new CreatedOSPCommandHandler(_mockOspRepository.Object, _mapper);

            var allMedItemsBeforeCount = (await _mockOspRepository.Object.GetAllAsync()).Count;

            var command = new CreatedOSPCommand()
            {
                Name = "",
            };

            var response = await handler.Handle(command, CancellationToken.None);

            var allMedItems = await _mockOspRepository.Object.GetAllAsync();

            response.Success.ShouldBe(false);
            response.ValidationErrors.Count.ShouldBe(1);
            allMedItems.Count.ShouldBe(allMedItemsBeforeCount);
            response.OspId.ShouldBeNull();
        }
    }
}
