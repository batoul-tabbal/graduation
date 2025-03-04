namespace grade.Repository
{
    public class Shelf
    {
        public string codeShelf {  get; set; }

        public int SectionId { get; set; }
        public virtual Section Sections { get; set; }

    }
}
