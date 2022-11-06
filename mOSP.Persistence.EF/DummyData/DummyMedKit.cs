using mOSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Persistence.EF.DummyData
{
    public class DummyMedKit
    {
        public static List<MedKit> Get()
        {
            MedKit k1 = new MedKit()
            {
                ContainerId = 1,
                Name = "Kit1",
                OspId = 1,
                CreatedDate = DateTime.Now,

            };

            MedKit k2 = new MedKit()
            {
                ContainerId = 2,
                Name = "Kit2",
                OspId = 1,
                CreatedDate = DateTime.Now,

            };

            MedKit k3 = new MedKit()
            {
                ContainerId = 3,
                Name = "Kit3",
                OspId = 1,
                CreatedDate = DateTime.Now,

            };

            MedKit k4 = new MedKit()
            {
                ContainerId = 4,
                Name = "Kit4",
                OspId = 1,
                CreatedDate = DateTime.Now,

            };

            MedKit k5 = new MedKit()
            {
                ContainerId = 5,
                Name = "Kit5",
                OspId = 1,
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
    }
}
