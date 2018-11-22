namespace CCByg.Model
{
    public partial class ItemAllocation
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }

        public Item Item { get; set; }
        public Project Project { get; set; }
    }
}
