namespace grade.Repository
{
    public class Section
    {
        public int SectionId { get; set; }
        public double SectionArea { get; set; }
        public double SectionHigh { get; set; }
        public int NumOfItems { get; set; }

        public Section(int sectionId, double area, double high, int items)
        { 
            SectionId = sectionId;
            SectionArea = area;
            SectionHigh = high;
            NumOfItems = 0;
        }
        public void AddItems( int count)
        {
            NumOfItems += count;
        }
        public void RemoveItems(int count)
        {
            if (count <= NumOfItems)
            {
                NumOfItems -= count;
            }
            else
            {
                throw new InvalidOperationException(" Cannot remove more items than available");
            }
        }
    }
}
