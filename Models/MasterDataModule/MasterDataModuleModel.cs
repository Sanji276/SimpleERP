namespace SimpleERP.Models.MasterDataModule
{
    public class MasterDataModuleModel
    {

    }
    public class ItemMasterData
    {
        public int Id { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescription { get; set; }
        public string? ItemType { get; set; }
        public string? ItemGroup { get; set; }
        public string? UoM { get; set; }
        public bool InventoryItem { get; set; } = true;
        public bool PurchaseItem { get; set; }
        public bool SalesItem { get; set; }
    }
}
