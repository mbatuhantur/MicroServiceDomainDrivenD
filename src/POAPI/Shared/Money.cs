using POAPI.SeedWork;

namespace POAPI.Shared
{
    public class Money : ValueObject
    {
        public string Currency {  get; set; }   
        public decimal Amount { get; set; }
        public Money(string currency, decimal amount)
        {
            Currency = currency;    
            Amount = amount;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return new object[] { Currency.Trim().ToUpper(), Math.Round(Amount, 2) };
        }
    }
}
