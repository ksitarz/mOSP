using mOSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Domain.Common
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public int ContainerId { get; set; }
        public Container Container { get; set; }



    }
}
