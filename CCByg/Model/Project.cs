using System;
using System.Collections.Generic;

namespace CCByg.Model
{
    public partial class Project
    {
        public Project()
        {
            ItemAllocations = new HashSet<ItemAllocation>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Deadline { get; set; }
        public bool IsFinished { get; set; }

        public ICollection<ItemAllocation> ItemAllocations { get; set; }
    }
}
