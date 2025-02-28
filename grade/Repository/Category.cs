namespace grade.Repository
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
        public virtual Category ParentCategory { get; set; }
        public virtual ICollection<Category> SubCategories { get; set; }
        public int SectionId { get; set; }
        public virtual Section Sections { get; set; }

        public virtual ICollection<Item> Items { get; set; }


        public Category()
        {
            Items = new List<Item>();
            SubCategories = new List<Category>();
        }

    }
}
