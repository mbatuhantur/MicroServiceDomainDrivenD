using POAPI.Aggregates.PO;

namespace POAPI.Data
{
    public class EFPurchaseOrderRepository : EFRepository<PoDbContext, PurchaseOrder>, IPurchaseOrderRepository
    {
        public EFPurchaseOrderRepository(PoDbContext db) : base(db)
        {
        }
    }
