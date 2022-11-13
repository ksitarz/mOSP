using mOSP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.OSPs.Queries
{
    public class OSPWithContainersViewModel
    {
        public int OspId { get; set; }
        public string Name { get; set; }
        public ICollection<ContainerDto> Containers { get; set; }
    }
}
