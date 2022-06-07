namespace CreateTypes.Classes
{
    public class Wine
    {
        public decimal Price { get; set; }
        public int Year { get; set; }

        public Wine(decimal price)
        {
            Price = price;
        }

        public Wine(decimal price, int year) : this(price)
        {
            Year = year;
        }
    }
}