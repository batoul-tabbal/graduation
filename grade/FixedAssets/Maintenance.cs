namespace grade.FixedAssets
{
    public class Maintenance
    {
        public int Id { get; set; }
        public int AssetsId { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public double Cost { get; set; }

        public void UpdateRemainingLife(Assets asset, double repairLife)
        {
            asset.remainingLife -= repairLife;
        }
    }
}
