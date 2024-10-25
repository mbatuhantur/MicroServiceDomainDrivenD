using POAPI.SeedWork;
using POAPI.Shared;

namespace POAPI.Aggregates.PO
{
    public class PurchaseRequest:AggregateRoot
    {
        public string Description { get; set; }

        public PurchaseRequestSatus Status { get; private set; }
        public Money Buget {  get; init; }

        private PurchaseRequest(Money buget, string description)
        {
            
            Description = description;
            Status = PurchaseRequestSatus.Submitted;
            Buget = buget;
        }

        private PurchaseRequest Create(Money buget, string description)
        {
            return new PurchaseRequest(buget,description);
        }

        public void Cancel()
        {
            Status = PurchaseRequestSatus.Canceled;
        }
    }
}
