using POAPI.SeedWork;

namespace POAPI.Aggregates.PO
{
    public class PurchaseRequestSatus : Enumeration
    {
        public static PurchaseRequestSatus Submitted => new PurchaseRequestSatus(100, "Submitted");
        public static PurchaseRequestSatus Canceled => new PurchaseRequestSatus(200, "Canceled");
        public static PurchaseRequestSatus Complete => new PurchaseRequestSatus(200, "Complete");

        public PurchaseRequestSatus(int id, string name) : base(id, name)
        {
        }
    }
}
