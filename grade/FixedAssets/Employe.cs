using grade.Repository;
namespace grade.FixedAssets
{
    public class Employe
    {
        public int employeId { get; set; }
        public string employeName { get; set; }
        public int SectionId { get; set; }
        public virtual Section Sections { get; set; }
    }
}
