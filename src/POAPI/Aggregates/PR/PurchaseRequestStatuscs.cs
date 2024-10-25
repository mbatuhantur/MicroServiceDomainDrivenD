using POAPI.SeedWork;

namespace POAPI.Aggregates.PO
{
    public class PurchaseRequestSatus : Enumeration
    {
        public static PurchaseRequestSatus Submitted => new PurchaseRequestSatus(100, "Submitted");
        public static PurchaseRequestSatus Canceled => new PurchaseRequestSatus(200, "Canceled");

        public PurchaseRequestSatus(int id, string name) : base(id, name)
        {
        }
    }
}
