using AutoMapper;
using Moq;
using mOSP.Application.Contracts.Persistence;
using mOSP.Application.Functions.MedItems.Commands;
using mOSP.Application.Mapper;
using mOSP.Application.UnitTest.Mocks;
using Shouldly;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace mOSP.Application.UnitTest.MedItems
{
    public class DeleteMedItemTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IMedItemRepository> _mockMedItemRepository;

        public DeleteMedItemTest()
        {
            _mockMedItemRepository = RepositoryMocks.GetMedItemRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            }
            );

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_Valid_MedItem_AddedToRepo()
        {
            var handler = new DeleteMedItemCommandHandler(_mockMedItemRepository.Object, _mapper);
            
            var allMedItemsBeforeCount = (await _mockMedItemRepository.Object.GetAllAsync()).Count;

            var command = new DeleteMedItemCommand()
            {
                ItemId = 5
            };

            var response = await handler.Handle(command, CancellationToken.None);

            var allMedItems = await _mockMedItemRepository.Object.GetAllAsync();

            
            allMedItems.Count.ShouldBe(allMedItemsBeforeCount - 1);
        }

    }
}
