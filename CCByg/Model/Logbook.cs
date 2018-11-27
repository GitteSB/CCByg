using System;
using System.Collections.Generic;

namespace CCByg.Model
{
    public partial class Logbook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Action { get; set; }
    }
}
