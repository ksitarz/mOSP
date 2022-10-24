using System;

namespace mOSP.Application.Functions.MedItems
{
    public class MedItemViewModel
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsIgnored { get; set; }
    }
}
