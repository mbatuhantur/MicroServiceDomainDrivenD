using POAPI.SeedWork;
using POAPI.Shared;

namespace POAPI.Aggregates.PO
{
    public class PurchaseRequest:AggregateRoot
    {
        public string Description { get; set; }

        public PurchaseRequestStatus Status { get; private set; }
        public Money Budget {  get; init; }

        private PurchaseRequest(Money budget, string description)
        {
            
            Description = description;
            Status = PurchaseRequestStatus.Submitted;
            Budget = budget;
        }

        private PurchaseRequest Create(Money buget, string description)
        {
            return new PurchaseRequest(buget,description);
        }

        public void Cancel()
        {
            Status = PurchaseRequestStatus.Canceled;
        }

        public void Complete()
        {
            Status = PurchaseRequestStatus.Complete;
        }
    }
}
