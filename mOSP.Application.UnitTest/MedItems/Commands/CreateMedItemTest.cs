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
    public class CreateMedItemTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IMedItemRepository> _mockMedItemRepository;

        public CreateMedItemTest()
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
            var handler = new CreatedMedItemCommandHandler(_mockMedItemRepository.Object, _mapper);
            
            var allMedItemsBeforeCount = (await _mockMedItemRepository.Object.GetAllAsync()).Count;

            var command = new CreatedMedItemCommand()
            {
                
                Name = "Item6",
                CreatedDate = DateTime.Now,
                ContainerId = 1,
                ExpirationDate = DateTime.Now.AddDays(56),
                IsIgnored = false
            };

            var response = await handler.Handle(command, CancellationToken.None);

            var allMedItems = await _mockMedItemRepository.Object.GetAllAsync();

            response.Success.ShouldBe(true);
            response.ValidationErrors.Count.ShouldBe(0);
            allMedItems.Count.ShouldBe(allMedItemsBeforeCount + 1);
            response.ItemId.ShouldNotBeNull();
        }

        [Fact]
        public async Task Handle_Valid_MedItem_EmptyName()
        {
            var handler = new CreatedMedItemCommandHandler(_mockMedItemRepository.Object, _mapper);

            var allMedItemsBeforeCount = (await _mockMedItemRepository.Object.GetAllAsync()).Count;

            var command = new CreatedMedItemCommand()
            {

                Name = "",
                CreatedDate = DateTime.Now,
                ContainerId = 1,
                ExpirationDate = DateTime.Now.AddDays(56),
                IsIgnored = false
            };

            var response = await handler.Handle(command, CancellationToken.None);

            var allMedItems = await _mockMedItemRepository.Object.GetAllAsync();

            response.Success.ShouldBe(false);
            response.ValidationErrors.Count.ShouldBe(1);
            allMedItems.Count.ShouldBe(allMedItemsBeforeCount);
            response.ItemId.ShouldBeNull();
        }

        [Fact]
        public async Task Handle_Valid_MedItem_ExpiredDate()
        {
            var handler = new CreatedMedItemCommandHandler(_mockMedItemRepository.Object, _mapper);

            var allMedItemsBeforeCount = (await _mockMedItemRepository.Object.GetAllAsync()).Count;

            var command = new CreatedMedItemCommand()
            {

                Name = "Item6",
                CreatedDate = DateTime.Now,
                ContainerId = 1,
                ExpirationDate = DateTime.Now,
                IsIgnored = false
            };

            var response = await handler.Handle(command, CancellationToken.None);

            var allMedItems = await _mockMedItemRepository.Object.GetAllAsync();

            response.Success.ShouldBe(false);
            response.ValidationErrors.Count.ShouldBe(1);
            allMedItems.Count.ShouldBe(allMedItemsBeforeCount);
            response.ItemId.ShouldBeNull();
        }

    }
}
