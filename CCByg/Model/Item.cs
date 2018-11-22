using System.Collections.Generic;

namespace CCByg.Model
{
    public partial class Item
    {
        public Item()
        {
            ItemAllocations = new HashSet<ItemAllocation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int AmountAvailable { get; set; }
        public int AmountAllocated { get; set; }

        public ICollection<ItemAllocation> ItemAllocations { get; set; }
    }
}
