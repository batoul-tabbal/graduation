using grade.Repository;

namespace grade.FixedAssets
{
    public class Assets
    {
        public int assetsId {  get; set; }
        public string assetsName { get; set; }
        public DateOnly dateOfEntry { get; set; }
        public string virtualdate { get; set; }

        public virtual ICollection<Type> Types { get; set; }
    }
}
