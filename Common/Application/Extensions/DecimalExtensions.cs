namespace Common.Application.Extensions
{
    public static class DecimalExtensions
    {
        public static bool Between(this decimal price, decimal oldPrice, decimal newPrice)
        {
            return (price > oldPrice && price <= newPrice) || (price < oldPrice && price >= newPrice);
        }
    }
}
