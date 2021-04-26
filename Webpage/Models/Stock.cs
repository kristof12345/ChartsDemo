using System.Collections.Generic;

namespace Webpage.Models
{
    public class Stock
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Exchange { get; set; }

        public string Currency { get; set; }

        public string Country { get; set; }

        public string Sector { get; set; }

        public string Industry { get; set; }

        public long MarketCapitalization { get; set; }

        public long NumberOfShares { get; set; }

        public string Description { get; set; }

        public decimal EPS { get; set; }

        public long EBITDA { get; set; }

        public decimal PayoutRatio { get; set; }

        public decimal ReturnOnEquity { get; set; }

        public decimal Dividend { get; set; }

        public decimal ForwardDividend { get; set; }

        public decimal Beta { get; set; }

        public decimal FairValue { get; set; }

        public decimal ExpectedReturn { get; set; }

        public List<StockPrice> Prices { get; set; }
    }
}
