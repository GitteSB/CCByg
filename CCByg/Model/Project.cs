using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CCByg.Model
{
    public partial class Project
    {
        public Project()
        {
            ItemAllocations = new HashSet<ItemAllocation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Zipcode { get; set; }
        public string Telephone { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Deadline { get; set; }

        public ICollection<ItemAllocation> ItemAllocations { get; set; }
    }
}
