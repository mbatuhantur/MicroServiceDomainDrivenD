using MediatR;

namespace POAPI.Aggregates.PQ
{
    public class TransformAsOrdered(string PurchaseRequestId,string PurchaseQuoteId) : INotification;
}
