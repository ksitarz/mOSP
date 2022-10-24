using mOSP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Domain.Entities
{
    public class OSP
    {
        public int OspId { get; set; }
        public string Name { get; set;}
        public ICollection<Container> Containers { get; set; }
    }
}
