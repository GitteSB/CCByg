using System;

namespace CCByg.Model
{
    public partial class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Zipcode { get; set; }
        public string Telephone { get; set; }
        public string Position { get; set; }
        public DateTime EmployedSince { get; set; }
    }
}
