namespace CreateTypes.Classes
{
    public class Stock
    {
        decimal currentPrice, sharesOwned;

        public decimal CurrentPrice
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }

        public decimal Worth
        {
            get => currentPrice * sharesOwned;
            set => sharesOwned = value / currentPrice;
        }
    }
}