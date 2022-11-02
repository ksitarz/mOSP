using Moq;
using mOSP.Application.Contracts.Persistence;
using mOSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Application.UnitTest.Mocks
{
    public class RepositoryMocks
    {
        public static Mock<IMedItemRepository> GetMedItemRepository()
        {
            var medItems = GetMedItems();

            var mockMedItemRepository = new Mock<IMedItemRepository>();
            mockMedItemRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(medItems);

            mockMedItemRepository.Setup(repo => repo.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((int id) =>
            {
                var item = medItems.FirstOrDefault(i => i.ItemId == id);
                return item;
            });

            mockMedItemRepository.Setup(repo => repo.AddAsync(It.IsAny<MedItem>())).ReturnsAsync(
                (MedItem medItem) =>
                {
                    medItems.Add(medItem);
                    return medItem;
                });

            mockMedItemRepository.Setup(repo => repo.DeleteAsync(It.IsAny<MedItem>())).Callback<MedItem>((entity) => medItems.Remove(entity));

            mockMedItemRepository.Setup(repo => repo.UpdateAsync(It.IsAny<MedItem>())).Callback<MedItem>((entity) => { medItems.Remove(entity); medItems.Add(entity); });

            return mockMedItemRepository;
        }

        public static Mock<IMedKitRepository> GetMedKitRepository()
        {
            var medKits = GetMedKits();

            var mockMedKitRepository = new Mock<IMedKitRepository>();
            mockMedKitRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(medKits);

            mockMedKitRepository.Setup(repo => repo.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((int id) =>
            {
                var continer = medKits.FirstOrDefault(i => i.ContainerId == id);
                return continer;
            });

            mockMedKitRepository.Setup(repo => repo.AddAsync(It.IsAny<MedKit>())).ReturnsAsync(
                (MedKit medKit) =>
                {
                    medKits.Add(medKit);
                    return medKit;
                });

            mockMedKitRepository.Setup(repo => repo.DeleteAsync(It.IsAny<MedKit>())).Callback<MedKit>((entity) => medKits.Remove(entity));

            mockMedKitRepository.Setup(repo => repo.UpdateAsync(It.IsAny<MedKit>())).Callback<MedKit>((entity) => { medKits.Remove(entity); medKits.Add(entity); });

            return mockMedKitRepository;
        }

        public static Mock<IOspRepository> GetOspRepository()
        {
            var osps = GetOSPs();

            var mockOspRepository = new Mock<IOspRepository>();
            mockOspRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(osps);

            mockOspRepository.Setup(repo => repo.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((int id) =>
            {
                var osp = osps.FirstOrDefault(i => i.OspId == id);
                return osp;
            });

            mockOspRepository.Setup(repo => repo.AddAsync(It.IsAny<OSP>())).ReturnsAsync(
                (OSP osp) =>
                {
                    osps.Add(osp);
                    return osp;
                });

            mockOspRepository.Setup(repo => repo.DeleteAsync(It.IsAny<OSP>())).Callback<OSP>((entity) => osps.Remove(entity));

            mockOspRepository.Setup(repo => repo.UpdateAsync(It.IsAny<OSP>())).Callback<OSP>((entity) => { osps.Remove(entity); osps.Add(entity); });

            return mockOspRepository;
        }

        public static List<MedItem> GetMedItems()
        {
            MedItem i1 = new MedItem()
            {
                ItemId = 1,
                Name = "Item1",
                CreatedDate = DateTime.Now,
                ContainerId = 1,
                //Container =
                ExpirationDate = DateTime.Now.AddDays(50),
                IsIgnored = false
            };
            MedItem i2 = new MedItem()
            {
                ItemId = 2,
                Name = "Item2",
                CreatedDate = DateTime.Now,
                ContainerId = 1,
                //Container =
                ExpirationDate = DateTime.Now.AddDays(51),
                IsIgnored = false
            };
            MedItem i3 = new MedItem()
            {
                ItemId = 3,
                Name = "Item3",
                CreatedDate = DateTime.Now,
                ContainerId = 1,
                //Container =
                ExpirationDate = DateTime.Now.AddDays(53),
                IsIgnored = false
            };
            MedItem i4 = new MedItem()
            {
                ItemId = 4,
                Name = "Item4",
                CreatedDate = DateTime.Now,
                ContainerId = 1,
                //Container =
                ExpirationDate = DateTime.Now.AddDays(54),
                IsIgnored = false
            };
            MedItem i5 = new MedItem()
            {
                ItemId = 5,
                Name = "Item5",
                CreatedDate = DateTime.Now,
                ContainerId = 1,
                //Container =
                ExpirationDate = DateTime.Now.AddDays(55),
                IsIgnored = false
            };

            List<MedItem> i = new List<MedItem>();
            i.Add(i1);
            i.Add(i2);
            i.Add(i3);
            i.Add(i4);
            i.Add(i5);

            return i;
        }

        public static List<MedKit> GetMedKits()
        {
            MedKit k1 = new MedKit()
            {
                ContainerId = 1,
                Name = "Kit1",
                CreatedDate = DateTime.Now,
                
            };

            MedKit k2 = new MedKit()
            {
                ContainerId = 2,
                Name = "Kit2",
                CreatedDate = DateTime.Now,

            };

            MedKit k3= new MedKit()
            {
                ContainerId = 3,
                Name = "Kit3",
                CreatedDate = DateTime.Now,

            };

            MedKit k4 = new MedKit()
            {
                ContainerId = 4,
                Name = "Kit4",
                CreatedDate = DateTime.Now,

            };

            MedKit k5 = new MedKit()
            {
                ContainerId = 5,
                Name = "Kit5",
                CreatedDate = DateTime.Now,

            };

            List<MedKit> k = new List<MedKit>();
            k.Add(k1);
            k.Add(k2);
            k.Add(k3);
            k.Add(k4);
            k.Add(k5);

            return k;
        }

        public static List<OSP> GetOSPs()
        {
            OSP o1 = new OSP()
            {
                OspId = 1,
                Name = "OSP1"
            };

            OSP o2 = new OSP()
            {
                OspId = 2,
                Name = "OSP2"
            };

            List<OSP> o = new List<OSP>();
            o.Add(o1);
            o.Add(o2);

            return o;
        }
    }
}
