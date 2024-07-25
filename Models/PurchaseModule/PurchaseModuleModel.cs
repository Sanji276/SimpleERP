namespace SimpleERP.Models.PurchaseModule
{
    public class PurchaseModuleModel
    {

    }
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public DateTime DocumentDate { get; set; }
        public DateTime DueDate { get; set; }
        public string? DocNumber { get; set; }
        public string? Series { get; set; }
        public string? VendorRefNumber { get; set; }
        public string? VendorCode { get; set; }
        public string? VendorName { get; set; }
    }
}
