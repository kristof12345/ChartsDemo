using System;
using System.Collections.Generic;

namespace Common.Application.Models
{
    public class PagedResult<T>
    {
        public long PageCount { get; set; }

        public List<T> Results { get; set; }

        public PagedResult()
        {
            Results = new List<T>();
        }

        public PagedResult(List<T> results, long count)
        {
            PageCount = (count + Range.PageSize - 1) / Range.PageSize;
            Results = results;
        }
    }

    public class Range
    {
        public static int PageSize { get; set; } = 9;

        public static readonly Range Default = new Range();

        public int Start { get; set; }

        public int Size { get; set; }

        public Range()
        {
            Start = 0;
            Size = PageSize;
        }

        public Range(int start, int size)
        {
            Start = start;
            Size = size;
        }

        public override string ToString()
        {
            return "?Start=" + Start + "&Size=" + Size;
        }
    }

    public class DateRange
    {
        public static readonly DateRange Default = new DateRange();

        public DateTime From { get; }

        public DateTime? To { get; }

        public DateRange()
        {
            From = DateTime.MinValue;
            To = DateTime.MaxValue;
        }

        public DateRange(DateTime? from, DateTime? to)
        {
            From = from ?? DateTime.MinValue;
            To = to ?? DateTime.MaxValue;
        }

        public override string ToString()
        {
            return "?From=" + From + "&To=" + To;
        }
    }
}
