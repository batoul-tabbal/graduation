namespace grade.Repository
{
    public class Repo
    {
        public int RepoId { get; set; }
        public double Area { get; set; }
        public double High {  get; set; }
        public string Address { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
        public List<int> NumOfSections { get; set; }
        public Repo ( int id, double area, double high, string address )
        { 
            RepoId = id;
            Area = area;
            High = high;
            Address = address;
            Sections = new List<Section>();
            NumOfSections = new List<int>();
        }
        public void AddSection(int sectionId)
        {
            if (!NumOfSections.Contains(sectionId))
            { NumOfSections.Add(sectionId); }
        }
        public void RemoveSection(int sectionId)
        {
            if (NumOfSections.Contains(sectionId))
            { NumOfSections.Remove(sectionId); }
        }
    }
}
