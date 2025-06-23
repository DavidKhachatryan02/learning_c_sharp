namespace _homework_9_task_3
{
    public enum Currency
    {
        USD,
        EUR,
        AMD
    }

    public struct CurrencyConverter
    {
        public decimal Amount;
        public Currency Currency;

        public CurrencyConverter(decimal amount)
        {
            Amount = amount;
            Currency = Currency.USD;
        }

        public decimal ConvertTo(Currency targetCurrency)
        {
            switch (targetCurrency)
            {
                case Currency.USD:
                    return Amount;
                case Currency.EUR:
                    return Amount * 0.85m;
                case Currency.AMD:
                    return Amount * 400m;
                default:
                    throw new ArgumentException($"Unsupported target currency: {targetCurrency}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var cc = new CurrencyConverter(100);
            decimal inEur = cc.ConvertTo(Currency.EUR);
            Console.WriteLine($"100 USD = {inEur:F2} EUR");

            var cc2 = new CurrencyConverter(50);
            decimal inAmd = cc2.ConvertTo(Currency.AMD);
            Console.WriteLine($"50 USD = {inAmd:F2} AMD");
        }
    }
}
