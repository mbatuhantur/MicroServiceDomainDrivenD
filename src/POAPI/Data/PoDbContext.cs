using Microsoft.EntityFrameworkCore;
using POAPI.Aggregates.PO;
using POAPI.Aggregates.PQ;
using POAPI.Shared;

namespace POAPI.Data
{
    public class PoDbContext :DbContext
    {
        public DbSet<PurchaseRequest> PurchaseRequests { get; set; }   
        public DbSet<PurchaseQuote> PurchaseQuote { get; set; }   
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Enumeration ve ValueObject için aşağıdaki gibi davranıyoruz.
            modelBuilder.Entity<PurchaseRequest>().OwnsOne<Money>(x => x.Budget).Property(x => x.Amount).HasColumnName("Budget_Amount");
            modelBuilder.Entity<PurchaseRequest>().OwnsOne<Money>(x => x.Budget).Property(x => x.Currency).HasColumnName("Budget_Currency");

            modelBuilder.Entity<PurchaseRequest>().OwnsOne<PurchaseRequestStatus>(x => x.Status).Property(x => x.Id).HasColumnName("Status_Id");
            modelBuilder.Entity<PurchaseRequest>().OwnsOne<PurchaseRequestStatus>(x => x.Status).Property(x => x.Name).HasColumnName("Status_Name");


            modelBuilder.Entity<PurchaseQuote>().OwnsOne<Money>(x => x.OfferAmount).Property(x => x.Amount).HasColumnName("offer_Amount");
            modelBuilder.Entity<PurchaseQuote>().OwnsOne<Money>(x => x.OfferAmount).Property(x => x.Currency).HasColumnName("Offer_Currency");

            modelBuilder.Entity<PurchaseQuote>().OwnsOne<PurchaseQuoteStatus>(x => x.Status).Property(x => x.Id).HasColumnName("Status_Id");
            modelBuilder.Entity<PurchaseQuote>().OwnsOne<PurchaseQuoteStatus>(x => x.Status).Property(x => x.Name).HasColumnName("Status_Name");

            modelBuilder.Entity<PurchaseOrder>().OwnsOne<PurchaseOrderStatus>(x => x.Status).Property(x => x.Id).HasColumnName("Status_Id");
            modelBuilder.Entity<PurchaseOrder>().OwnsOne<PurchaseOrderStatus>(x => x.Status).Property(x => x.Name).HasColumnName("Status_Name");

            base.OnModelCreating(modelBuilder);
        }
    }
}
