﻿using POAPI.Aggregates.PQ;
using POAPI.SeedWork;

namespace POAPI.Aggregates.PO
{
    public class PurchaseOrder : AggregateRoot
    {
        public PurchaseOrder() { }
        public string PurchaseQuoteId { get; init; }
        public string PurchaseRequestId { get; init; }

        public PurchaseOrderStatus Status { get; private set; }

        private PurchaseOrder(string purchaseQuoteId, string purchaseRequestId)
        {
            PurchaseQuoteId = purchaseQuoteId;
            PurchaseRequestId = purchaseRequestId;
            Status = PurchaseOrderStatus.Submitted;
            AddEvent(new PurchaseOrderSubmited(purchaseRequestId));
        }

        public static PurchaseOrder Create(string purchaseQuoteId, string purchaseRequestId)
        {
            return new PurchaseOrder(purchaseQuoteId, purchaseRequestId);
        }

        public void TransformAsInvoiced()
        {
            Status = PurchaseOrderStatus.Invoiced;
        }


    }


}
