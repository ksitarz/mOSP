using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.OSPs.Queries
{
    public class OSPWithMedKitsViewModel
    {
        public int OspId { get; set; }
        public string Name { get; set; }
        public ICollection<MedKitDto> Containers { get; set; }
    }
}
