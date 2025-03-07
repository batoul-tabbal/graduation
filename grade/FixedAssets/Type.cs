namespace grade.FixedAssets
{
    public class Type
    {
        public int typeId {  get; set; }
        public string typeName { get; set; }
        public string description { get; set; }
        public int parentId { get; set; }
        public int assetId { get; set; }
        public virtual Assets Assets { get; set; }

    }
}
