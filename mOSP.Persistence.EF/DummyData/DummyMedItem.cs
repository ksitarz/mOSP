using mOSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Persistence.EF.DummyData
{
    public class DummyMedItem
    {
        public static List<MedItem> Get()
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
    }
}
