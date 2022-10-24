using System;

namespace mOSP.Application.Functions.MedKits
{
    public class MedItemDto
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedData { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsIgnored { get; set; }

        public int ContainerId { get; set; }
    }
}
