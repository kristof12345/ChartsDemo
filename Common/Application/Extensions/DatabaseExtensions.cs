using System.Linq;
using Common.Application.Models;

namespace Common.Application.Extensions
{
    public static class DatabaseExtensions
    {
        public static IOrderedQueryable<TSource> OrderByWithDirection<TSource>(this IQueryable<TSource> source, Ordering<TSource> ordering)
        {
            return ordering.Descending ? source.OrderByDescending(ordering.Expression) : source.OrderBy(ordering.Expression);
        }
    }
}
