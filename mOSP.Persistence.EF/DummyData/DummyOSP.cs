using mOSP.Domain.Entities;
using System.Collections.Generic;

namespace mOSP.Persistence.EF.DummyData
{
    public class DummyOSP
    {
        public static List<OSP> Get()
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
