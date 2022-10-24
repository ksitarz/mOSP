using System.Collections.Generic;

namespace mOSP.Application.Functions.MedKits
{
    public class MedKitViewModel
    {
        public int ContainerId { get; set; }
        public string Name { get; set; }
        public ICollection<MedItemDto> Items { get; set; }
    }
}
