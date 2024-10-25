using POAPI.SeedWork;
using POAPI.Shared;

namespace POAPI.Aggregates.PQ
{

    
    public class PurchaseQuote : AggregateRoot
    {
        public PurchaseQuote() { }
        public Money OfferAmount { get; init; }

        public string PurchaseRequestId { get; init; }

        public PurchaseQuoteStatus Status { get; private set; }  

        private PurchaseQuote(Money offerAmount, string purchaseRequestId)
        {
            OfferAmount = offerAmount;
            Status = PurchaseQuoteStatus.Submitted;
            PurchaseRequestId = purchaseRequestId;
        }
        public static PurchaseQuote Create(Money offerAmount, string purchaseRequestId)
        {
            return new PurchaseQuote(offerAmount, purchaseRequestId);
        }

        public void TransformAsOrder()
        {
            Status = PurchaseQuoteStatus.Approved;
            AddEvent(new TransformAsOrdered(PurchaseRequestId,Id));
            // Event fırlatıp Order oluştur.
        }

        public void Reject()
        {
            Status = PurchaseQuoteStatus.Rejected;
        }

    }
}

