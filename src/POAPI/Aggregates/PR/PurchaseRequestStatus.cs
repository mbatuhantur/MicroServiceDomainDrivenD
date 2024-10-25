using POAPI.SeedWork;

namespace POAPI.Aggregates.PO
{
    public class PurchaseRequestStatus : Enumeration
    {
        public static PurchaseRequestStatus Submitted => new PurchaseRequestStatus(100, "Submitted");
        public static PurchaseRequestStatus Canceled => new PurchaseRequestStatus(200, "Canceled");
        public static PurchaseRequestStatus Complete => new PurchaseRequestStatus(200, "Complete");

        public PurchaseRequestStatus(int id, string name) : base(id, name)
        {
        }
    }
}
