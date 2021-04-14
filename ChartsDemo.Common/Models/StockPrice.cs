﻿using System;

namespace ChartsDemo.Common.Shared
{
    public class StockPrice
    {
        public DateTime Date { get; set; }

        public decimal Open { get; set; }

        public decimal High { get; set; }

        public decimal Low { get; set; }

        public decimal Close { get; set; }

        public double Volume { get; set; }
    }
}
