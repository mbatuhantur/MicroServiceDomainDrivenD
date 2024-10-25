using MediatR;

namespace POAPI.Aggregates.PO
{
    public class PurchaseOrderSubmited(string PurchaseRequestId):INotification;
}
