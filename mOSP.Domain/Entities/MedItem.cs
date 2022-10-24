using mOSP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Domain.Entities
{
    public class MedItem : Item
    {
        public DateTime ExpirationDate { get; set; }
        public bool IsIgnored { get; set; }
    }
}
