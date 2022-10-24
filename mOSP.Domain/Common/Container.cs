using mOSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Domain.Common
{
    public class Container
    {
        public int ContainerId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public int OspId { get; set; }
        public OSP Osp { get; set; }

        public ICollection<Item> Items { get; set; }

    }
}
