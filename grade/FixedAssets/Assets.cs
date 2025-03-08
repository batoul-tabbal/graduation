using grade.Repository;

namespace grade.FixedAssets
{
    public class Assets
    {
        public int assetsId {  get; set; }
        public string assetsName { get; set; }
        public double defaultLife { get; set; }
        public double remainingLife { get; set; }

        public virtual ICollection<Type> Types { get; set; }
    }
}
