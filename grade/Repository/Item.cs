namespace grade.Repository
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly Expiration {  get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public Item()
        {
            Categories = new List<Category>();
        }
    }
}
